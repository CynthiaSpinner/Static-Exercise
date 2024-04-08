namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(24);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(12);
             
            double answer = Math.Round(celsius, 1);
            Console.WriteLine($"{answer}");

            Console.WriteLine("please enter a celsius number to convert to fahrenheit");
            var userInput = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"{fahrenheit}");
        }
    }
}
