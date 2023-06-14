﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Registration
    {
        public void Register()
        {
            string pattern_name = @"^[A-Z][a-z]{2,}";
            string input_name = "";

            Regex obj = new Regex(pattern_name);

            while (true)
            {
                Console.Write("Please enter a name: ");
                input_name = Console.ReadLine();

                if (obj.IsMatch(input_name))
                {
                    Console.WriteLine($"'{input_name}' is a valid User Name.\n");
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                }
                Console.Write("Please enter last name: ");
                input_name = Console.ReadLine();

                if (obj.IsMatch(input_name))
                {
                    Console.WriteLine($"'{input_name}' is a valid last Name.\n");
                    //break;
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                }
            }
        }
        public void EmailRegistration()
        {
            string pattern_email = @"^[A-Za-z.-_]{3,}[@][A-Za-z]{2,}[.][A-Za-z]{2,3}[.]{0,1}[A-Za-z]{0,2}$"; //abc.xyz@bl.co.in
            string input_email = "";

            Regex obj = new Regex(pattern_email);

            while (true)
            {
                Console.Write("Enter your email: ");
                input_email = Console.ReadLine();

                if (obj.IsMatch(input_email))
                {
                    Console.WriteLine($"'{input_email}' is a valid Email.\n");
                }
                else
                {
                    Console.WriteLine("Invailid Input!! \nTry Again...\n");
                }
            }
        }
            public void MobileRegistration()
            {
                string pattern_mobile = @"^[9][1][ ][6-9][0-9]{9}$"; //91 9340596362
                string input_mobile = "";

                Regex obj = new Regex(pattern_mobile);

                while (true)
                {
                    Console.Write("Enter your mobile number: ");
                    input_mobile = Console.ReadLine();

                    if (obj.IsMatch(input_mobile))
                    {
                        Console.WriteLine($"'{input_mobile}' is a valid mobile number.\n");
                    }
                    else
                    {
                        Console.WriteLine("Invailid Input!! \nTry Again...\n");
                    }
                }
            }
        }
    }

           
        
    

        
    

            
        
    

    

