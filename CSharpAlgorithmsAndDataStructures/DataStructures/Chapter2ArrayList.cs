using System;
using System.Collections.Generic;
using System.Text;

/*
 * Design and implement a class that uses an array to mimic the behavior of the ArrayList class. 
 * Include as many methods from the ArrayList class as possible. Write a program to test your implementation.
 */
namespace CSharpAlgorithmsAndDataStructures.DataStructures
{
    class Chapter2ArrayList<T>
    {
        private T[] list;
        private int capacity;
        private int count;
        private const int CAPACITY_INCREMENT = 16;
        public Chapter2ArrayList()
        {
            list = new T[CAPACITY_INCREMENT];
            capacity = 16;
            count = 0;
        }

        public Chapter2ArrayList(int value)
        {
            list = new T[value];
            capacity = value;
            count = 0;
        }

        /*
         * Add(): Adds an element to the ArrayList.  
         */
        public int Add(T item)
        {
            count++;
            if (count > capacity)
            {
                list = CopyTo(new T[capacity + CAPACITY_INCREMENT]);
            }
            list[count - 1] = item;
            return count - 1;
        }

        /*
         * AddRange(): Adds the elements of a collection to the end of the ArrayList.  
         */
        public void AddRange(T[] range)
        {
            for (int i = 0; i < range.Length; i++)
            {
                Add(range[i]);
            }
        }


        /*
         * CopyTo(): Copies the ArrayList or a segment of it to an array. 
         */
        public T[] CopyTo(T[] newArray)
        {
            int maxCount = newArray.Length >= capacity ? capacity : newArray.Length;
            for (int i = 0; i < maxCount; i++)
            {
                newArray[i] = list[i];
            }
            return newArray;
        }

        /*         
         * Capacity: Stores the number of elements the ArrayList can hold.
         */
        public int Capacity()
        {
            return capacity;
        }

        /*
         * Clear(): Removes all elements from the ArrayList.
         */
        public void Clear()
        {
            list = new T[capacity];
        }

        /*
         * Contains(): Determines if a speciﬁed item is in the ArrayList.
         */
        public Boolean Contains(T element)
        {
            foreach (T obj in list)
            {
                if (obj.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public int Count()
        {
            return count;
        }

        /*
         * GetRange(): Returns a subset of the ArrayList as an ArrayList. 
         */
        public T[] GetRange(int index, int count)
        {
            T[] newArr = new T[count];
            //Need to learn how to throw exceptions/errors to handle this properly..
            for (int i = 0; i < count; i++)
            {
                newArr[i] = list[index + i];
            }
            return newArr;
        }

        /*
         * IndexOf(): Returns the index of the ﬁrst occurrence of the speciﬁed item.
         */
        public int IndexOf(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        /*
         * Insert(): Insert an element into the ArrayList at a speciﬁed index. 
         */
        public void Insert(T element, int index)
        {
            if (index < count)
            {
                count++;
                if (count < capacity)
                {

                }
            }
        }

        /*
         * Remove(): Removes the ﬁrst occurrence of the speciﬁed item.
         */
        public void Remove(T element)
        {
            T[] temp = new T[capacity - 1];
            int i = 0;
            bool first = true;
            foreach (T item in list)
            {
                if (item.Equals(element) && first)
                {
                    capacity--;
                    count--;
                    first = false;
                    continue;
                }
                if (i < capacity - 1)
                {
                    temp[i++] = item;
                }
            }
            if (!first)
            {
                list = temp;
            }
        }

        /*
         * RemoveAt(): Removes an element at the specified index. 
         */
        public void RemoveAt(int index)
        {
            T[] temp = new T[capacity - 1];
            int tempInt = 0;
            bool removed = false;
            for (int i = 0; i < count; i++)
            {
                if (i == index)
                {
                    removed = true;
                    continue;
                }
                if (tempInt < capacity - 1)
                {
                    temp[tempInt++] = list[i];
                }
            }
            if (removed)
            {
                list = temp;
                count--;
                capacity--;
            }
        }


        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(list[0]);
            for (int i = 1; i < count; i++)
            {
                sb.Append(", ").Append(list[i]);
            }
            return sb.ToString();
        }

        /*
         * Reverse(): Reverses the order of the elements in the ArrayList.
         */
        public void Reverse()
        {
            // count/2  for say 5 -> 2 -> i = 0 , i = 1    for 6 -> i = 0, 1, 2      count-1 = 5 -0, 5-1, 5-2 = 5, 4, 3
            for (int i = 0; i < count / 2; i++)
            {
                T tempVal = list[i];
                list[i] = list[count - 1 - i];
                list[count - 1 - i] = tempVal;
            }
        }

        /*
         * TrimToSize(): Sets the capacity of the ArrayList to the number of elements in the ArrayList.
         */
         public void TrimToSize()
        {
            if (!capacity.Equals(count))
            {
                capacity = count;
                T[] temp = new T[capacity];
                for(int i = 0; i < capacity; i++)
                {
                    temp[i] = list[i];
                }
                list = temp;
            }
        }

        /* 
         * GetEnumerator(): Returns an enumerator to iterate over the ArrayList.  
         * Insert(): Insert an element into the ArrayList at a speciﬁed index. 
         * InsertRange():Inserts the elements of a collection into the ArrayList starting at the speciﬁed index.
         * Item(): Gets or sets an element at the speciﬁed index.  
         * Sort(): Alphabetically sorts the elements in the ArrayList.  
         */


    }
}
