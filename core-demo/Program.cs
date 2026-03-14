namespace core_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#");

            string name = "Tom";
            int age = 20;
            bool isAdult = age >= 18;
            PrintUserInfo(name,age,isAdult);
        }
        static void PrintUserInfo(string name,int age,bool isAdult)
        {
            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I am {age} years old.");
            Console.WriteLine($"Adult:{isAdult}");
        }

    }
}
