using System.Text;

namespace LINQ_01
{
    internal class Program
    {
        //static var Print(var X)
        //{
        //    return X;
        //}

        //static dynamic Print(dynamic X)
        //{
        //    return X;
        //}



        static void Main(string[] args)
        {



            #region C# Keywords : Implicitly Typed Local Variable [var, dynamic]

            // C# Keywords; Implicitly Typed Local Variable [var — dynamic]

            #region C# Keyword : var

            // var
            //var Data01 = "Ahmed";

            // Complier Will Detect Datatype Of Local Variable Based On Initial Value, At Compilation Time
            // Must Be Initialized
            // Can't Initialized Local Variable With Null
            // Can't Change Datatype Of The Local Variable After Initialization
            // Can't Use var as Parameter Or Retrurntype


            //var X = 12;

            //var X; //Invalid

            //var X = null;

            //Data01 = 12;


            /*
             var X = 12;
             X = "Ahmed";
             X = new Object()
             */


            #endregion

            #region C# Keyword : dynamic

            //dynamic

            //dynamic Data02 = "Ahmed"; // Like var in JS

            // CLR Detect Datatype Of Local Variable Based On Last Value,At Runtine
            // Don't Need To Be Initialized
            // Can Initialized Local Variable With Null
            // Can Change Datatype Of The Local Variable After Initialization
            // Can Use var as Parameter Or Retrurntype
            // Be Careful When Using dynamic Keyword

            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 12;

            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 'a';

            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.9;

            //Console.WriteLine(Data02.GetType().Name);

            //dynamic X = null;

            //Console.WriteLine(Data02.GetType().Name);



            #endregion

            #endregion


            #region Extension Methods
            // Extension Methods

            //int Number = 12345; //54321

            // var Result = IntExtension.Reverse(Number);

            // Console.WriteLine(Result);

            // Number.Reverse();

            //var Result = Number.Reverse();

            //Number.Reverse();
            //Console.WriteLine(Result);

            #endregion



        }
    }
}
