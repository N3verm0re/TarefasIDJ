using System;

namespace TempratureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit;
            int temprature;
            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] splits = command.Split(' ');
                temprature = Int32.Parse(splits[0]);
                unit = splits[1];

                if(unit == "Celsius")
                {
                    double newTemprature = Converter.ConvertFahrenheit(temprature);
                    unit = "Fahrenheit";
                    Console.WriteLine("{0} {1}", newTemprature, unit);
                } 
                else 
                {
                    double newTemprature = Converter.ConvertCelsius(temprature);
                    unit = "Celsius";
                    Console.WriteLine("{0} {1}", newTemprature, unit);
                }

                command = Console.ReadLine();
            }
        }
    }
}
