namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(24);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(12);

            Console.WriteLine($"{celsius}");
            Console.WriteLine($"{fahrenheit}");
        }
    }
}
