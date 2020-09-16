namespace CSharpCourse.ClassesAndMethods
{
    public class StaticMethods
    {
        public class StaticCalc
        {
            public int Sum(int a, int b)
            {
                return a + b;
            }

            public static int Multiply(int a, int b)
            {
                return a * b;
            }
        }
        public static void Execute()
        {
            var result = StaticCalc.Multiply(5, 5);
            var staticCalc = new StaticCalc();
            var resultSum = staticCalc.Sum(10, 10);

            System.Console.WriteLine(result);
        }
    }
}