using System.Runtime.Intrinsics.Arm;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            /*Write a program that allows the user to enter a number then print it.
             */
            Console.Write("Please Enter the number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input);
            #endregion
            #region Question2
            /*Write C# program that converts a string to an integer, 
             * but the string contains non-numeric characters. 
             * And mention what will happen 
             */
            string Number = "77k";
            int convertedNumber = int.Parse(Number);
            Console.WriteLine(Number);
            //There is an exception ' The input string '77k' was not in a correct format'
            #endregion
            #region Question3
            /*Write C# program that Perform a simple arithmetic operation
             * with floating-point numbers And mention what will happen
             */
            float num1 = .1f;
            float num2 = .3f;
            Console.WriteLine($"number1 + number2 ={num1 + num2}");
            //Floating-point numbers can represent fractions but may have small rounding errors due to how they're stored in binary.
            #endregion
            #region Question4
            /*Write C# program that Extract a substring from a given string.
             */
            Console.Write("Enter the Original text: ");
            string originalText = Console.ReadLine();
            Console.Write("Enter the starting index: ");
            int startingIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("The length of the word");
            int wordLength = int.Parse(Console.ReadLine());
            Console.WriteLine($"Extracted String is {originalText.Substring(startingIndex, wordLength)}");
            #endregion
            #region Question5
            /*
             Write C# program that Assigning one value type variable to another
            and modifying the value of one variable and mention what will happen
             */
            int x = 5;
            int y = x; //Here y took a copy from X valure (5)

            x = 10; //This Modification will not affect y

            Console.WriteLine("x = " + x); // x = 10
            Console.WriteLine("y = " + y); // y = 5
            #endregion
            #region Question6
            /*Write C# program that Assigning one reference type variable to another 
             * and modifying the object through one variable and mention what will happen
             */
            car c1= new car();
            car c2 = c1;
            c1.name = "BMW";
            Console.WriteLine(c1.name); //BMW
            Console.WriteLine(c2.name);//BMW TOOK THE SAME VALUE AS C1 CAUST THIS REFERENCES AT THE SAME OBJECT

            #endregion
            #region Question7
            /*7-	Write C# program that take two string variables and print them as one variable 
             */
            Console.Write("Enter the first text: ");
            string firstText= Console.ReadLine();
            Console.Write("Enter the secolnd: ");
            string secondText= Console.ReadLine();
            Console.WriteLine($"The ouput text is {firstText+" "+secondText}");
            #endregion
            #region Question8
            /*
             8-	Which of the following statements is correct about the C#.NET code snippet given below?

            -b)	A value 1 will be assigned to d.

             */
            int d;
            d = Convert.ToInt32(!(false)); //and not false is a true converting it ot integer value will be 1
            Console.WriteLine(d);//1  

            #endregion
            #region Question9
            /*
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            The ouput will be '6 1' cause the first term acts as an intger so it does not accept fractions.
            */
            #endregion
            #region  Question10
            //The ouput is  7 7
            //++num increases 1 to 2 then get it to the formula 
            //z++ Get the 5 to the formula then increase it to 6
            //++z increase 6 to 7 then get it to the formula 
            // The final result is 2+5+" "+7
            #endregion
        }
    }
    public class car
    {
       public string name;
    }
}
