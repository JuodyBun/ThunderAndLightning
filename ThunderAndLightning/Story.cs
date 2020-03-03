using System;
using System.Collections.Generic;
using System.Text;

namespace ThunderAndLightning
{
    public class Introduction
    {
        public string name;
        public string response;
        public string GetName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine().ToUpper();
            Console.WriteLine($"{name}, is that correct? Type 'NO' to re-enter your name or press 'Enter' to continue the story.");
            response = Console.ReadLine().ToUpper();
            return GetName();
        }
    }
}
