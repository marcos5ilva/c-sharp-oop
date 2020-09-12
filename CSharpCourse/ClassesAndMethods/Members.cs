namespace CSharpCourse.ClassesAndMethods
{
    public class Members
    {
        public static void Execute()
        {
            Person person = new Person();
            person.Name = "Alice";
            person.Age = 8;

            System.Console.WriteLine(person.Introduce());
        }

    }
}