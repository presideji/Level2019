using System;

namespace First2019Console
{
    public class Person
    {
        public string FirstName;
        public string Lastname;
        public static string NewFirstName; //we need to make this static ans we want to use initally a non
        //static in a static class and it wil complain
        public static string NewLastName;

        public void IntroduceAnthony()
        {
            Console.WriteLine($"My name is {FirstName} {Lastname}");
            //Console.WriteLine("My name is Anthony");
        }

        public static void IntroduceDeji()
        {
            Console.WriteLine($"My name is {NewFirstName} {NewLastName}");
        }

    }
}