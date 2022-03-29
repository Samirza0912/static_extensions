using System;
using at_lesson.Helper;
using at_lesson.Models;

namespace at_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region static
            //string word = "Lorem";
            Person p1 = new Person();
            //Console.WriteLine($"{p1.id} {Person.count}");
            //person.Info();
            Person.count = 10;
            #endregion

            //Test test = new Test(); //instance olmur
            Test.Info();
            Program program = new Program();
            //program.GetInfo();
            //GetInfo();
            Console.WriteLine(Test.Id);
            Test.Info();
            string word = "lorem";
            word.Reverse();
            //Console.WriteLine(Extension.Reverse(word));
            int num = 10;
            Console.WriteLine(num.Pow(3));
            Console.WriteLine(word.IsUpper());
      
        }
        //static public void GetInfo()
        //{

        //}

    }
    
    
}
