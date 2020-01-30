using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);

            //selection switch between heat index and wind chill

            if (temperature > 50)
            {

                //Get realative humidity from user

                Console.WriteLine("Enter the Relative Humidity");

                int relativeHimidty = int.Parse(Console.ReadLine());

                //Calculate heat index

                decimal heatIndex = .5m * (temperature + 61.0m +
                                            ((temperature - 68.0m) * 1.2m) +
                                            (relativeHimidty * 0.094m));

                Console.WriteLine("Heat Index is " + heatIndex);

            }
            else
            {
                // Get the windspeed from the user
                Console.WriteLine("Enter the wind speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                // Calculate the wind chill

                windChill = 35.74 + (0.6125 * temperature)
                            - 35.75 * Math.Pow(windSpeed, 0.16)
                            + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);
            }

            
        }
    }
}
