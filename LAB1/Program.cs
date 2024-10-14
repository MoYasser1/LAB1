namespace LAB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = 0, minutes = 0, seconds = 0;
            Console.WriteLine("Please enter hours (or press Enter to skip):");
            string hoursInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(hoursInput) && int.TryParse(hoursInput, out hours))
            {
                hours = int.Parse(hoursInput);
            }
            Console.WriteLine("Please enter minutes (or press Enter to skip):");
            string minutesInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(minutesInput) && int.TryParse(minutesInput, out minutes))
            {
                minutes = int.Parse(minutesInput);
            }
            Console.WriteLine("Please enter seconds (or press Enter to skip):");
            string secondsInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(secondsInput) && int.TryParse(secondsInput, out seconds))
            {
                seconds = int.Parse(secondsInput);
            }

            Duration duration = new Duration(hours, minutes, seconds);
            Console.WriteLine(duration.GetString());
        }
    }
}
