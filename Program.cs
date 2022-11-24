namespace Drow_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            pointofreturn:
            Console.Write("Enter hight");
            int hight = int.Parse(Console.ReadLine());
            if (hight <= 0)
            {
                Console.Write("Your number is smaller then or equal 0, reenter");
                goto pointofreturn;
            }

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