﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumberPgm
{
    public class Harmonicnumber
    {
        int n;

        
        public void HarmonicNumberMethod()
        {
            Console.WriteLine("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
           
            double result = 0;
            
            for (int i = 1; i<=n; i++)
            {
                result = (result + 1) / i;
            }
            Console.WriteLine($"Harmonic number = {result}");
        }
    }
}
