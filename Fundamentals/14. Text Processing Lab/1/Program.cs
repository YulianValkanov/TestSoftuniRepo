﻿using System;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            string removeText = Console.ReadLine();

            string text = Console.ReadLine();

            int index = text.IndexOf(removeText);

            while (index!=-1)
            {
               text= text.Remove(index, removeText.Length);

                index= text.IndexOf(removeText);
            }

            Console.WriteLine(text);
        }

        
    }
}
