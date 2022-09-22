namespace Height
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the height of the person (in centimetres):");
            double height = Convert.ToDouble(Console.ReadLine());

            if (height < 135.0)
                Console.Write("The person is short \n");
            else if (height >= 180.0)
                Console.Write("The person is tall");
            else
                Console.Write("Average height.\n\n");
        }
    }
}