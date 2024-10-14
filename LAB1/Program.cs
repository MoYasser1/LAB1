using static LAB1.StudentLibrary;

namespace LAB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////Mohamed Yasser Mohamed///////////////////////////////////
            ///////////////////////////////////////  Task1 ////////////////////////////////////////////////////

            int hours = 0, minutes = 0, seconds = 0;
            Console.WriteLine("Please enter hours ==> (or press Enter to skip):");
            string hoursInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(hoursInput) && int.TryParse(hoursInput, out hours))
            {
                hours = int.Parse(hoursInput);
            }
            Console.WriteLine("Please enter minutes ==> (or press Enter to skip):");
            string minutesInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(minutesInput) && int.TryParse(minutesInput, out minutes))
            {
                minutes = int.Parse(minutesInput);
            }
            Console.WriteLine("Please enter seconds ==> (or press Enter to skip):");
            string secondsInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(secondsInput) && int.TryParse(secondsInput, out seconds))
            {
                seconds = int.Parse(secondsInput);
            }

            Duration duration = new Duration(hours, minutes, seconds);
            Console.WriteLine(duration.GetString());

            ///////////////////////////////////////  Task2 ////////////////////////////////////////////////////
            

            Console.WriteLine("Enter Your Name Please");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter Your age Please");
            int age = int.Parse( Console.ReadLine());
            Console.WriteLine("Enter Your Specialization Please");
            String Specialization = Console.ReadLine();


            Student student1 = new Student("Ahmed", 21, "Computer Science");
            student1.DisplayInfo();
            if (student1.IsAdult())
            {
                Console.WriteLine("The student is an adult");
            }
            else
            {
                Console.WriteLine("The student is not an adult");
            }
            Console.ReadLine();
        }
    }
}
