﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("글자를 입력하고 엔터 키를 누르세요.");
            string userInput = Console.ReadLine();

            Console.Write("입력한 글은 ");
            Console.Write(userInput);
            Console.WriteLine("입니다");
        
        }
    }
}
