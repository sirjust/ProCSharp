﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static int AddWrapper(int x, int y)
        {
            // Do some validation here
            return Add();

            int Add() => x + y;
        }

    }
}
