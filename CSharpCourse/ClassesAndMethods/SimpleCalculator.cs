namespace CSharpCourse.ClassesAndMethods
{
    public class SimpleCalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
    }

    class AddCalculator
    {
        int memory;

        public AddCalculator Sum(int a)
        {
            memory += a;

            return this;
        }

        public AddCalculator Multiply(int a)
        {
            memory *= a;

            return this;
        }

        public AddCalculator Clear()
        {
            memory = 0;
            return this;
        }

        public AddCalculator Print()
        {
            System.Console.WriteLine(memory);
            return this;
        }

        public int Result()
        {
            return memory;
        }
    }
    public class ReturnMethods
    {
        public static void Execute()
        {
            var simpleCalculator = new SimpleCalculator();

            var result = simpleCalculator.Sum(3, 7);
            System.Console.WriteLine(result);

            var addCalc = new AddCalculator();

            addCalc.Sum(3).Sum(7).Print();
        }
    }
}