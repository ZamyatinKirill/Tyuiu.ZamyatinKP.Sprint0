﻿using System;

using Tyuiu.ZamyatinKP.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ZamyatinKP.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Кирилл"));
            Console.ReadKey();
        }
    }
}