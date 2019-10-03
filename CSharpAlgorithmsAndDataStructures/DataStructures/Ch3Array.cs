using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithmsAndDataStructures.DataStructures
{
    class Ch3Array
    {
        private int[] arr;
        private int upper;
        private int numElements;

        public Ch3Array(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }

        public void Insert(int item)
        {
            arr[numElements++] = item;
        }

        public void DisplayElements()
        {
            for(int i = 0; i <= upper; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        public void Clear()
        {
            for(int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
            }
            numElements = 0;
        }
    }
}
