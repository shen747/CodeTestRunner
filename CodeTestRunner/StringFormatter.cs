using System.Text;

namespace CodeTestRunner
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {

        //Code to improve
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            //Original Code
            //StringBuilder qry = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0]));
            //if (items.Length > 1)
            //{
            //    for (int i = 1; i < items.Length; i++)
            //    {
            //        qry.Append(string.Format(", {0}{1}{0}", quote, items[i]));
            //    }
            //}
            //return qry.ToString();

            //OPTION 1 : Can Replace the above code with below LINQ expression
            /*
              Benefits:
                        1. Conciseness: The LINQ expression is more concise and easier to read
                        2. Maintainability: The LINQ expression is easier to maintain and modify
                        3. Performance: The LINQ expression may be more performant for large arrays
                        4. IndexOutOfRangeException is avoided as we are not accessing array elements directly
                           when encountering null or empty array IT will return empty string.
             */
            //return string.Join(", ", items.Select(item => $"{quote}{item}{quote}"));


            //OPTION 2 : Can Improve the Original code with below code

            //Handle null or empty array
            if (items == null || items.Length == 0)
            {
                return string.Empty;
            }

            //Use a more descriptive variable name
            StringBuilder commaSeparatedListBuilder = new StringBuilder();
            //SImple loop starting from 0 and handle comma within the loop
            for (int i = 0; i < items.Length; i++)
            {
                //when the index is greater than 0, append comma before the item
                if (i > 0)
                {
                    commaSeparatedListBuilder.Append(", ");
                }
                commaSeparatedListBuilder.Append($"{quote}{items[i]}{quote}");
            }

            return commaSeparatedListBuilder.ToString();
        }
    }
}
