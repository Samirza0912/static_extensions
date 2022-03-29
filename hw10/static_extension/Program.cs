using System;
using static_extension.Models;

namespace static_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            //IAccount (interface):
            //- PasswordChecker() - parametr olaraq string password qəbul edir.
            //- ShowInfo()
            //User class (IAccount-u implement edir)
            //- Id
            //- Fullname
            //- Email
            //- Password
            //- PasswordChecker() - PasswordChecker methodu -
            //gələn string password dəyərinin şərtləri ödəyib ödəmədiyini yoxlayıb true/false dəyər qaytarir.
            //Şərtlər:
            //                        - şifrədə minimum 8 character olmalıdır
            //                        - şifrədə ən az 1 böyük hərf olmalıdır
            //                        - şifrədə ən az 1 kiçik hərf olmalıdır
            //                        - şifrədə ən az 1 rəqəm olmalıdır
            //- ShowInfo() - bu method console-a user-in Id, Fullname və email dəyərlərini yazdırır
            //ps: Id dəyəri hər dəfə bir user obyekti yaranan zaman avtomatik artmalıdır
            //            və qıraqdan id dəyərini dəyişmək olmamalıdı ancaq get etmək olar.
            //            User yarandığı zaman email və password təyin edilməsi məcburidir.
            //            User-ə şifrə təyin edilərkən şifrənin PasswordChecker methodunun şərtlərini ödəməsi lazımdır.

            do
            {
                UserClass user = new UserClass();
                Console.Clear();
                Console.WriteLine("please enter your ID");
                user.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter your fullname");
                user.Fullname = (Console.ReadLine());
                Console.WriteLine("please enter your email");
                user.Email = (Console.ReadLine());
                Console.WriteLine("please enter your password");
                user.Password = (Console.ReadLine());

            } while (Console.ReadKey().Key != ConsoleKey.Escape);


        }
    }
    interface IAccount
    {
        public void PasswordChecker(string password);
        public void ShowInfo();

    }
}
