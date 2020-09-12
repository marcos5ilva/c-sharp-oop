namespace CSharpCourse.ClassesAndMethods
{
    public class Person
    {
        public string Name;
        public int Age;

        public string Introduce()
        {

            return string.Format($"Hi, my  name is {Name}, age {Age} years old");
        }

    }
}