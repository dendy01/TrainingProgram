using TrainingProgram;

namespace TestApp
{
    public class Test
    {
        public static void InitWithFile()
        {
            Table table = new Table("../../../table.csv");

            table.Print();


            Console.WriteLine(table["name", 3]);
            Console.WriteLine(table["age", 4]);
        }

        public static void InitRandom()
        {
            Table table = new Table(5, 10);

            table.InitRandom(-10, 20);

            table[2, 3] = "50";

            table.Print();


            Console.WriteLine(table[2, 2]);
        }
    }
}