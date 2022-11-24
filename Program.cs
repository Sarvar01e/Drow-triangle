namespace Drow_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hight");
            int hight = int.Parse(Console.ReadLine());

            int startpoint = 1;

            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < startpoint; j++)
                {
                    Console.Write("#");
                }
                startpoint++;
                Console.WriteLine();

                while (startpoint == hight)
                {
                    for (int k = 0; k < startpoint; k++)
                    {
                        for (int u = 0; u < hight; u++)
                        {
                            Console.Write("#");

                        }
                        hight--;
                        Console.WriteLine();
                    }
                }
            }


        }
    }
}