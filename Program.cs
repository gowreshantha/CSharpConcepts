using CSharpConcepts;
using System.Reflection.Metadata.Ecma335;
/// <summary>
/// C# Concepts
/// </summary>
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

        #region A Simple Coffee program used conditions and loops
        //ProgramCoffee.CoffeeProcess();
        #endregion

        #region Non Generic & Generic Collections
        //Non Generic are ArrayList, Hastbale etc
        //Generic are List<>, Dictionary<>
        #endregion

        #region Extension Methods
        /*
         * Extension methods enable you to add methods to existing types without
           creating a new derived type, recompling or otherwise modifying the original
           type. Extension methods are a special kind of static methods, but they are called
           as if they were instance methods on the extended type

           The most common extension methods are the LINQ standard query operators
           that add query functionality to the existing Collections and Generic Collections types
         */
        #endregion

        #region Enums
        /*
         * ENnum - we can ensure that the code written is strongly typed as opposed to constants declared within a variable
           ex: string browser = "firefox"; //this will be case sensitive & a typo leads to problem
         */
        #endregion

        #region LINQ
        /*
            Language-Integrated Query
            1. Query Expression
            2. Method based

        //query expression
        var qName = from user in users
            where user.age > 40
            select user.Name;

        //Method-based
        var mName = users.Select(x => x.Name);
        var userlist = users.Where(x => x.Age > 40).Select(x => x);

        Select Projections:

        Projections refers to the operation of transforming an object into a new form that
        often consists only of those properties that will be subsequently used.
        By using projection, you can construct a new type that is built frome ach object
        1. Select
        2. SelectMany
        ex:
        var userDetail = from users in users
                 where user.Name == "Sa,"
                 select new {FirstName = user.Name, PhoneNo = user.Phone};
        var addresses = users.Where(x => x.age > 40).SelectMany(x => x,Addresses);
         */
        #endregion

        #region Delegates and lamda expression
        Printer p = (message) => Console.WriteLine($"the delegate message printed is {message}");
        p("Hello Gowresh ");
        #endregion

        #region Function and Action delegates
        /*
         Func<T,TResult> Delegates
         Func<> delegates are used mainly where there requires an method which has
         One input (generic type) &
         Once output (generic type)
         */
        Func<string, string> func = delegate (string print)
        {
            return print;
        };
        //with lamda
        Func<string, string> funcLam = (print) => { return print; };
        Console.WriteLine(func("Hi delegate using Func<> which removes the need for delegate declaration explicitly"));
        Console.WriteLine(funcLam("Hi delegate with lamda using Func<> which removes the need for delegate declaration explicitly"));
        /*
        Action<T>
        encapsulates a method that has a single parameter and does not return a value
        diff b/w Action<> & Func<> is this
        1. Func<> for sure have a return value
        2. Action<> for sure WILL NOT have a return value
        */
        Action<string> act = delegate (string print)
        {
            Console.WriteLine(print);
        };
        Action<string> actLam = (print) => { Console.WriteLine(print); };
        act("Action<> Hello");
        actLam("Lamda Action<> Hello");
        #endregion

        #region Tuples
        /*
         * Tuples

        Tuples are the way to return multiple return values from a method
        This option was available even in earlier version, but are less optiomal like
        - Out Paramters
         */
        var tuple = ReturnInfo();
        Console.WriteLine(tuple);
        var tupleWithParamName = ReturnInfoParmName();
        Console.WriteLine(tupleWithParamName);
        Console.WriteLine($"Tuples -> Name is {tuple.Item1} Int is {tuple.Item2} String is {tuple.Item3}");
        Console.WriteLine($"Tuples -> Name is {tupleWithParamName.name} Int is {tupleWithParamName.age} String is {tupleWithParamName.someText}");
        #endregion
    }

    public delegate void Printer(String message);

    public static (string, int, string) ReturnInfo()
    {
        return ("Name", 20, "Hello");
    }
    public static (string name, int age, string someText) ReturnInfoParmName()
    {
        return ("Name", 20, "Hello");
    }
}