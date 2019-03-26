using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace First2019Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.ReadKey();
            //*Variable – a name given to a storage location 

            //    *Two types --> 
            //**************************************************************************
            //    * Primitive Types 
            //**************************************************************************
            //    * Byte 
            //    * Short 
            //    * Long 
            //    * Float 
            //    * Double 
            //    * Boolean 
            //    * Char 
            //    * Non-Primitive Type 
            //******************************************************************************
            //    * String 
            //    * Array 
            //    * Enum 
            //    * class 
            //            */
            ////char alhpabet = '4';
            ////byte numberByte = 12;

            ////string studentNameInUniversity = "Andre";
            ////const int driverLicenceMinimumAge = 17;
            ////float number = 44.87F;
            ////double multinum = 66.87D;
            ////bool inDebt = false;
            ////now replave the above types with "var"
            ////var alhpabet = '4';
            //var numberByte = 12;
            //var studentNameInUniversity = "Andre";
            //var driverLicenceMinimumAge = 17;
            ////var number = 44.87F;
            ////var multinum = 66.87D;
            ////var inDebt = false;
            //var status = "cool";


            //Console.WriteLine(studentNameInUniversity);
            //Console.WriteLine(driverLicenceMinimumAge);
            //Console.WriteLine("--------------------");

            //Console.WriteLine($"my name is{studentNameInUniversity} and I live at number {numberByte} street");
            //Console.WriteLine($"my name is{studentNameInUniversity} and I live at number {numberByte} street. I am {status}.");
            ////Another way to write the above is
            //Console.WriteLine();
            //Console.WriteLine("my name is {0} and I live at number {1}", studentNameInUniversity, numberByte);
            ////Another way to write this
            //Console.WriteLine();
            //Console.WriteLine("My name is " + studentNameInUniversity + " and I live at " + numberByte + " street");
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine();
            //Console.ReadLine();

            //Console.WriteLine("----------------------------");
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine();

            //Console.WriteLine(long.MinValue);
            //Console.WriteLine(long.MaxValue);

            //var numberOne = 33;
            //var numberTwo = 44;
            //var result = numberOne + numberTwo;
            //var resultSub = numberTwo - numberOne;
            //var resultMul = numberTwo * numberOne;
            //var resultRem = numberTwo%2;
            //var resultRemtwo = numberOne%2;

            //Console.WriteLine(numberOne);

            //Console.WriteLine(numberOne--);
            //Console.WriteLine(numberOne);
            //Console.WriteLine($"{numberOne} plus {numberTwo} is equal to {result}");
            //Console.WriteLine($"{numberTwo} minus {numberOne} is equal to {resultSub}");
            //Console.WriteLine($"{numberOne} times {numberTwo} is equal to {resultMul}");
            //Console.WriteLine($"{numberTwo} reminder 2 is equal to {resultRem}");
            //Console.WriteLine($"{numberOne} reminder 2 is equal to {resultRemtwo}");

            //var comOne = resultRem <= resultRemtwo;
            //Console.WriteLine(comOne);

            //*********************************************************************************
            /*
             * AND -- &&
             * OR -- ||
             * NOT -- |
             */

            //if ((numberOne > 12) || (numberTwo < 0))
            //{
            //    Console.WriteLine("This statement is true");
            //}
            //else
            //{
            //    Console.WriteLine("this statement is false");
            //}

            //Console.WriteLine($"{numberOne}");
            //Console.WriteLine($"{numberTwo}");
            //if (numberOne > 55)
            //{
            //    Console.WriteLine($"{numberOne} is greater than 55");
            //}
            //else
            //{
            //    Console.WriteLine($"{numberOne} is less than 5");
            //}
            //if (numberOne > 55)
            //{
            //    Console.WriteLine($"{numberOne} is greater than 55");
            //}
            //else if (numberTwo < 55)
            //{
            //    if (long.MaxValue > int.MaxValue)
            //    {
            //        Console.WriteLine(long.MaxValue);
            //    }
            //    Console.WriteLine($"{numberTwo} is less than 55" );
            //}
            //else
            //{
            //    Console.WriteLine("None of the numbers are valid");
            //}

            //switch (numberOne)
            //{
            //    case 22:
            //        Console.WriteLine("Print me if 22");
            //        break;

            //    case 30:
            //        Console.WriteLine("Print me if 30");
            //        break;
            //    case 33:
            //        Console.WriteLine("Print me if 33");
            //        break;

            //    default:
            //        Console.WriteLine("I do not exist");
            //        break;
            // }

            //Console.WriteLine("confirm you have left the switch statement");

            /*
             * Iteration Statement -- tells you how mant times a statement will be executed
             * ***********************************************
             * Do Statement
             * While statement
             * Do-While
             * For loop
             * Foreach loop
             * Break
             * Continue
             */

            //when the user types into the console, it's defaultn datatype is a string
            //prompt
            //Console.WriteLine("Please, enter your age");
            //var age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"My age is {age}");

            //while (age != 44)
            //{
            //    Console.WriteLine("Please enter your age");
            //    age = int.Parse(Console.ReadLine());

            //    if (age == 44)
            //    {
            //        Console.WriteLine($"You have enter correct age, which is {age}");

            //    }
            //    //else
            //    //{
            //    //    Console.WriteLine($"The age given {age} is not accepted");
            //    //    break;
            //    //}

            //Console.WriteLine("Please enter a number between 5 and 10");
            //var num = int.Parse(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine("Just show me at least once");
            //} while (ageNew != 44);
            //for (var count = 40; count < num; count++)
            //{
            //    Console.WriteLine($"Counting num is {num}");
            //}
//**********************************************************************************************************
            var names = new[] { "andre", "ola", "Joe", "ola" };
            var timesFound = 0;

            foreach (var name in names)
            {

                Console.WriteLine(name);

                if (name.Equals("ola"))
                {
                    Console.WriteLine("I found the 1st ola");
                    //break;
                    timesFound++;
                }

               if (timesFound == 2)
                {
                    Console.WriteLine("I have found the 2nd instance of Ola");
                    break;
                }

            }

            //**************************************************************************************************************

            //Option 1
            //var anthony = new Person();
            //anthony.FirstName = "Anthony";
            //anthony.Lastname = "Guy";
            //anthony.IntroduceAnthony();

            //Option 2
            var anthony = new Person
            {
                FirstName = "Anthony",
                Lastname = "Guy"
            };
            anthony.IntroduceAnthony();

            Person.NewFirstName = "Deji";
            Person.NewLastName = "President";
            Person.IntroduceDeji();
            Calculator.Addition(2, 4);
            Calculator.Multiplication(3, 5);
            Calculator.Subtraction(9, 4);
            Calculator.Division();
            Console.WriteLine("-----------------");
           







            
            Console.ReadLine();



        }

    }
}
