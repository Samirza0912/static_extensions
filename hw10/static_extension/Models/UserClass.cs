﻿using System;
namespace static_extension.Models
{
    public class UserClass : IAccount
    {
        
        private string _Password;

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get { return _Password; } set
            {
                if (value.Length >= 8 && Cases(value) == true)
                {
                    Console.WriteLine("password is set");

                    return;
                }
                Console.WriteLine("the length of password cannot be less than 8 symbols, " +
                        "you should type at least 1 upper symbol, " +
                        "1 lower symbol and number");
                return;
            } }
        public void use (string fullname, string email, string password)
        {
            Fullname = fullname;
            Email = email;
            Password = password;

        }
        
         public void PasswordChecker(string password)
        {

       
        }
        public bool Cases(string pass)
        {
            bool res1 = false;
            bool res2 = false;
            bool res3 = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i]) == true)
                {
                    res2 = true;
                }
                if (char.IsNumber(pass[i]) == true)
                {
                    res1 = true;
                }
                if (char.IsLower(pass[i]) == true)
                {
                    res3 = true;
                }
            }
            bool res = res1 && res2 && res3;
            return res;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Id} {Fullname} {Email}");
        }
    }
}
