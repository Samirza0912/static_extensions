using System;
namespace at_lesson.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public static int count;
        public int id;
        public Person()
        {
            count++;
        }
        public void Info()
        {
            count = 10;
        }

    }
    static class Test
    {
        public static int Id { get; set; }
        static Test()
        {
            Console.WriteLine("working");
        }
        public static void Info()
        {

        }
        

    }
    
   // class Test1:Test//miras almir
}
