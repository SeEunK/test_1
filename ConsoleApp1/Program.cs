namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{ 2023.01.05  Add new feature user input /Beta
            string userInput = string.Empty;
            Console.WriteLine("This program convert Cm to Inch");
            Console.WriteLine("Input Cm Value : ");
            userInput= Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(cmInput);
            //} 2023.01.05  Add new feature user input /Beta
            ruler.Run();
        }
    }
    public class Ruler
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            private set { Centimeter = (int)(value / ONE_INCH); }
        }
        public Ruler(int cmValue) { Centimeter = cmValue; }
        public void Run()
        {
            Console.WriteLine($"{Centimeter}cm 는 {Inch} inch 입니다.");
     

        }

    }
}