using System;

namespace SnailTask
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Write 3 numbers: distance, day distance, night distance");
            string inputLine = Console.ReadLine();
            string[] splitLine = inputLine.Split(' ');
            try
            {
                if (splitLine.Length != 3)
                {
                    throw new Exception("Numbers are incorrect");
                }
                var distance = Double.Parse(splitLine[0]);
                var dayDistance = Double.Parse(splitLine[1]);
                var nightDistance = Double.Parse(splitLine[2]);

                if (dayDistance <= nightDistance || distance < dayDistance)
                    throw new Exception("Wrong numbers");

                if (dayDistance <=0 || nightDistance < 0 || distance <= 0)
                    throw new Exception("Numbers must be greater than 0");

                double days = CalculateDays(distance, dayDistance, nightDistance);
                Console.WriteLine("The distance will be overcome for {0:F1} days", days);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
       }

            static double CalculateDays(double distance, double dayDistance, double nightDistance)
        {
            double days = Math.Ceiling((distance - dayDistance) / (dayDistance - nightDistance));
            days = days + ((distance - (dayDistance - nightDistance) * days) / dayDistance);
            return days;
        }
    }
}
