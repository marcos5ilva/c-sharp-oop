namespace CSharpCourse.ClassesAndMethods
{
    class Calc
    {
        int memory;

        public Calc Sum(int number)
        {
            memory += number;
            return this;
        }

        public Calc Print()
        {
            System.Console.WriteLine(memory);
            return this;
        }
    }
    public class AddCalcReview
    {
        public static void Execute()
        {
            Calc calc = new Calc();
            calc.Sum(5).Sum(12).Print();
        }
    }
}