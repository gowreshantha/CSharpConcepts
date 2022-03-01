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

           Nullable types brdge the diff b/w C# types and Database types
            
           Null Coalescing Opertaor:
         */
        int? TotalTickets = 100, Total = null;
        int AvailableTickets = TotalTickets ?? 0;
        int Totals = Total ?? 0;
        Console.WriteLine("AvailableTickets = {0} and Totals = {1} ",AvailableTickets,Totals);
        #endregion

    }
}