﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_L1_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextClass myText = new TextClass();
            Console.WriteLine("Insert a test");
            myText._mystring1 = myText.AddStringToTheTextClass();
            Console.WriteLine(myText._mystring1);
            Console.ReadLine();
        }
    }
}
