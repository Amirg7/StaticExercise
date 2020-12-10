using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var celsius = TempConverter.FarenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"After conversion:");
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");

        }

       

    }


}
