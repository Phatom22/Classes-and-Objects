using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //creating object to call method
                Car momentum = new Car();

                ///creating an object for class car
                Car bmw = new Car();
                Console.WriteLine(" ***BMW*** ");
                Console.WriteLine("enter colour of car:");
                bmw.color = Convert.ToString(Console.ReadLine());//user to input data

                Console.WriteLine("enter model of the car:");
                bmw.model = Convert.ToString(Console.ReadLine());

                Console.WriteLine("enter maxSpeed of the car:");
                bmw.maxSpeed = Convert.ToInt32(Console.ReadLine());

                momentum.FullSpeed();

                Console.WriteLine(" ***BENZ*** ");
                //creating another object for class car
                Car benz = new Car();
                Console.WriteLine("enter colour of car:");
                benz.color = Convert.ToString(Console.ReadLine());

                Console.WriteLine("enter model of the car:");
                benz.model = Convert.ToString(Console.ReadLine());

                Console.WriteLine("enter maxSpeed of the car:");
                benz.maxSpeed = Convert.ToInt32(Console.ReadLine());

                //calling a method full speed from class car
               
                momentum.FullSpeed();
            }
            catch
            {
                Console.WriteLine("ERROR PLS USES A LETTERS ONLY OR NUMBERS WHERE SPEED IS REQUIRED");
            }
            Console.ReadLine();
        }
        //method
       
    }
    class Car
    {
        //fields this are class variables 
        public string color;
        public string model;
        public int maxSpeed;

        //method inside class car
        public void FullSpeed()
        {
            Console.WriteLine("the car is moving faster ");
        }

    }
}
