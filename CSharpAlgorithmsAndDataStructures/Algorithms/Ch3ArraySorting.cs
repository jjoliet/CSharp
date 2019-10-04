using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithmsAndDataStructures.DataStructures
{
    class Ch3ArraySorting
    {
        private int[] arr;
        private int upper;
        private int numElements;

        public Ch3ArraySorting(int size)
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
            Console.WriteLine();
        }

        public void Clear()
        {
            for(int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
            }
            numElements = 0;
        }
        // Sorting algorithms below
        
        public void BubbleSort()
        {
            int temp;
            for(int outer = upper; outer >= 1; outer--)
            {
                for(int inner = 0; inner <= outer-1; inner++)
                {              
                    if((int)arr[inner] > arr[inner + 1])
                    {
                        //Swap
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
                //this.DisplayElements();
            }
        }

        public void SelectionSort()
        {
            int minIndex, temp;
            for(int outer = 0; outer <= upper-1; outer++)
            {
                minIndex = outer;
                for(int inner = outer+1; inner <= upper; inner++)
                {
                    if(arr[inner] < arr[minIndex])
                    {
                        minIndex = inner;
                    }
                }
                temp = arr[minIndex];
                arr[minIndex] = arr[outer];
                arr[outer] = temp;
                //this.DisplayElements();
            }
        }

        public void InsertionSort()
        {
            int temp, inner;
            for(int outer = 1; outer <= upper; outer++)
            {
                inner = outer;
                temp = arr[outer];
                while (inner > 0 && arr[inner-1] >= temp)
                {
                    //When the element being checked (temp) is less than or equal to
                    //The element to its left, shift that element right and temp left.
                    //Continue shifting until we have reached either the end of the array
                    //or the element is smaller.
                    arr[inner] = arr[inner - 1];
                    inner--;
                }
                arr[inner] = temp;
                //this.DisplayElements();
            }
        }
    }
}
