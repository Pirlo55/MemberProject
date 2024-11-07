using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Test.Math;

namespace Test
{   
    internal class Program
    {

        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
       
        static void Main(string[] args)
        { Console.WriteLine("Welcome to C# Course!");

            // Reference type and value type
            var number = 10;
            Increment(number);
            Console.WriteLine(number);
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);

            //
            var john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

    

            //for looping test
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            //Ramdom class
            var random = new Random();
            const int passwordLength = 10;
            char[] buffer = new char[passwordLength];
            for (var j = 0; j < passwordLength; j++)
                buffer[j] = (char)('A' + random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);

            //Demo Array Test
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flag = new bool[3];
            flag[0] = true;

            Console.WriteLine(flag[0]);
            Console.WriteLine(flag[1]);
            Console.WriteLine(flag[2]);

            

            //Demo Strings Test
            var fName = "Mosh";
            var lName = "Hamedani";
            var fullName = fName + " " + lName;
            var myfullName = string.Format("My Name is {0} {1}", fName, lName);
            var name = new string[3] { "Jack", "John", "Mary" };
            var formattedName = string.Join(",", name);
            Console.WriteLine(formattedName);

            //Enum Test
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine(method.ToString());
            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod),methodName);

            //Demo while loop test

            //while (true)
            //{
            //    Console.Write("Enter your name: ");
            //    var input = Console.ReadLine();

            //    if (!string.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@echo: " + input);
            //        continue;
            //    }
            //    break;
            //}

            //If else and switch case
            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;
            float price = (isGoldCustomer) ? 19.95f : 29.95f; 
            Console.WriteLine(price);

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's is Autumn and beautiful season");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's the best to go to beach");
                    break;
                default:
                    Console.WriteLine("I don't understand that season");
                    break;

            }

            //Foreach loop
            var num = new int[] { 1, 2, 3, 4 };
            foreach(var num1 in num)
            {
                Console.WriteLine(num1);
            }

            //Arrays Test
            var numberInArray = new [] { 2, 5, 4, 3, 6, 7 };

                //Length
            Console.WriteLine("Length: "+ numberInArray.Length);
                //IndexOf()
            var index = Array.IndexOf(numberInArray,4);
            Console.WriteLine("Index of 4 is " + index);
                //Clear()
            Array.Clear(numberInArray, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numberInArray)
                Console.WriteLine(n);
                //Copy()
            int[] another = new int[3];
            Array.Copy(numberInArray, another, 3);
            Console.WriteLine("Effect of Copy() ");
            foreach (var n in another)
                Console.WriteLine(n);
            //Sort()
            Array.Sort(numberInArray);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in numberInArray)
                Console.WriteLine(n);
                //Reverse()
            Array.Reverse(numberInArray);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numberInArray)
                Console.WriteLine(n);

            //List 
            var numberList =new List<int> {1,2,3,4};
            numberList.Add(1);
            numberList.AddRange(new int[3] {5,6,7});
            foreach (var numList in numberList)
                Console.WriteLine(numList);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numberList.IndexOf(1));
            Console.WriteLine("Last index of 1: "+ numberList.LastIndexOf(1));

            Console.WriteLine("Count: " + numberList.Count);

            //numberList.Remove(1);
            //foreach (var numList in numberList)
            //    Console.WriteLine(numList);

            for(var i=0; i < numberList.Count; i++)
            {
                if (numberList[i] == 1)
                    numberList.Remove(numberList[i]);
            }
            foreach (var numList in numberList)
                Console.WriteLine(numList);

            numberList.Clear();
            Console.WriteLine("Count: " + numberList.Count);

            //Date and Time
            var datetime = new DateTime(2024,11,1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: "+now.Hour);
            Console.WriteLine("Minute: " + now.Minute);


        }
    }
}
