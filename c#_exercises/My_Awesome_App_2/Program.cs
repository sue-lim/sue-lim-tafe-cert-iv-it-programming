namespace My_Awesome_App_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // console appearance 
            Console.Title = "The Knight Story";
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("A proud knight named...");
            Console.ReadLine();

            Console.WriteLine("...who asked him what he wanted to drink?");
            Console.ReadLine();

            Console.WriteLine("...shouted the knight! The bartender shushed him quickly");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("But it was too late... A dragon ate them both");

            // wait before closing 
            Console.ReadKey();

        }
    }
}