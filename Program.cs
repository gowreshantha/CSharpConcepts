public class Program
{
    public static void Main(string[] args)
    {
        #region Built-in types
        /*
         * Boolean type - Only true or false
         * Integral types - sbyte, byte, short, ushort, int, unit, long, ulong, char
         * Floating types - float and double
         * Decimal types
         * String type
         */
        Console.WriteLine("Minimum Value int : "+int.MinValue+ " Maximum Value int : " + int.MaxValue);
        Console.WriteLine("Minimum Value float : " + float.MinValue + " Maximum Value float : " + float.MaxValue);
        #endregion

        #region Nullable Types
        /*
         * In C# types are divided into 2 categories
           Value Types - int, float, double, structs, enums etc.
           Reference Types - Interface, Class, delegates, arrays etc.

           By default value types are non nullable. To make them nullable use ?
           int i = 0 (i is non nullable, i cannot be set to null, i = null will generate compiler error)
           int? j = 0 (is is nullable int, so j=null is legal)

           Nullable types bridge the diff b/w C# types and Database types
            
           Null Coalescing Opertaor:
         */
        int? TotalTickets = 100, Total = null;
        int AvailableTickets = TotalTickets ?? 0;
        int Totals = Total ?? 0;
        Console.WriteLine("AvailableTickets = {0} and Totals = {1} ",AvailableTickets,Totals);
        #endregion

        #region Implicit and Explicit coversion
        /*
          Implict conversion is done by the compiler:
          - When there  is no loss of information if the conversion is done
          - If there is no possibility of throwing exceptions during the conversion

          Ex: Converting an int to a float will not loose any date and no exception will be thrown, 
          hence an implicit conversion can be done.

          When converting a float to an int, we loose the frational part and also a possibility of overflow exception. hence, 
          in this case an explicit conversion is required.
          For explict conversion we can use cast operator or the convert class in c#

          Diff b/w Parse and TryParse
          If the number is in a string format you have 2 options
          -Parse() and TryParse()

          Parse() method throws an exception if it cannot parse the value,
          whereas TryParse() returns a bool indicating whether it succeeded or failed.

          Use Parse() if you are sure the value will be valid, otherwise use tryParse()
         */

        string input = "100", input2 = "200N";
        int number = int.Parse(input);
        int result = 0;
        bool isNumber =  int.TryParse(input2, out result);
        Console.WriteLine(number +" "+ isNumber);
        #endregion

        #region Arrays
        /*
        An array is a collection of similar data types.

        Adv - Array are strongly typed.
        Dis - Arrays cannot grow in size once initialized.
        Have to rely on integral indices to store or retrieve items from the array.
        */
        #endregion
    }
}