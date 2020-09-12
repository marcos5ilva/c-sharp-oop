namespace CSharpCourse.Fundamentals
{
    public class VariablesAndConsts
    {
        public static void Execute()
        {
            double radius = 4.5;
            const double PI = 3.14;

            double area = PI * radius * radius;
            System.Console.WriteLine($"The circumference area is: {area}");
        }
    }
}