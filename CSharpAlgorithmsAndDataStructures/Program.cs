﻿using CSharpAlgorithmsAndDataStructures.DataStructures;
using System;

namespace CSharpAlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCustomArray();
            /*
            Timer timer = new Timer();
            timer.StartTime();
            int[] arr = BuildArray(10000);
            DisplayVals(arr);
            timer.StopTime();
            timer.Result();
            */
            /*
            int[,] grades = new int[,] { { 1, 82, 74, 89, 100 }, 
                                         { 2, 93, 96, 85, 86 }, 
                                         { 3, 83, 72, 95, 89 }, 
                                         { 4, 91, 98, 79, 88 } }; 
            int last_grade = grades.GetUpperBound(1); 
            double average = 0.0; 
            int total; 
            int last_student = grades.GetUpperBound(0); 
            for(int row = 0; row <= last_student; row++) 
            { 
                total = 0; 
                for (int col = 1; col <= last_grade; col++)
                { 
                    total += grades[row, col];                    
                }
                average = total / last_grade;
                Console.WriteLine("Average:" + average);
            }
            */
        }

        static int[] BuildArray(int size)
        {
            if(size < 0)
            {
                size = 10;
            }
            int[] arr = new int[size];
            for(int i=0; i < size; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        static void DisplayVals(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine("Value of array item: {0}", i);
            }
        }
        

        static void chapter1()
        {
            NewCollection names = new NewCollection();
            names.Add("David");
            names.Add("Bernica");
            names.Add("Raymond");
            names.Add("Clayton");
            foreach(Object name in names)
            {
                Console.WriteLine(name);
            }
            String numOfNames = "Number of names: {0}";
            Console.WriteLine(numOfNames, names.Count());
            names.Remove("Raymond");
            Console.WriteLine(numOfNames, names.Count());
            names.Clear();
            Console.WriteLine(numOfNames, names.Count());
        }

        static void UseCustomArray()
        {
            Chapter2ArrayList<int> al = new Chapter2ArrayList<int>();
            Console.WriteLine("The capacity is: {0} and the count is {1}", al.Capacity(), al.Count());
            al.Add(15); 
            Console.WriteLine("The capacity is: {0} and the count is {1}", al.Capacity(), al.Count());
            int[] vals = { 1, 3, 5, 9, 7, 99, 10, 3, 4, 5, 9, 0, 10, 13 };
            al.AddRange(vals);
            Console.WriteLine("The capacity is: {0} and the count is {1}", al.Capacity(), al.Count());
            Console.WriteLine("Contains {0}: {1}", 10, al.Contains(10));
            Console.WriteLine(al.toString());
            //al.Remove(10);
            //al.RemoveAt(3);
            al.Reverse();
            Console.WriteLine(al.toString());

        }
    }
}
