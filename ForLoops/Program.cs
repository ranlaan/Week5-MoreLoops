﻿using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsooli 
            //"I will not skateboard in the hall"
            //10 korda

            for (int i = 0; i < 10; i++) //int 1 = 0 - start, i < 10 - end; i++ step
            {
                Console.WriteLine($"{i+1}. I will not skateboard in the hall");
            }




        }
    }
}
