﻿using System;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");

            Console.WriteLine("\n==============||===============\n");

            Registration reg = new Registration();
            reg.Register();
        }
    }
}