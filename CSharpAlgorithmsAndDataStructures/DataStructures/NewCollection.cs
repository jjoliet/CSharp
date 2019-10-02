using System;
using System.Collections;
using System.Text;

namespace CSharpAlgorithmsAndDataStructures.DataStructures
{
    class NewCollection : CollectionBase
    {
        public void Add(Object o)
        {
            InnerList.Add(o);
        }

        public void Remove(Object o)
        {
            InnerList.Remove(o);
        }

        public int Count()
        {
            return InnerList.Count;
        }

        public new void Clear()
        {
            InnerList.Clear();
        }

        public void Insert(Object o, int index) 
        {
                InnerList.Insert(index, o);
        }
        public Boolean Contains(Object o)
        {
            return InnerList.Contains(o);
        }

        public int IndexOf(Object o)
        {
            return InnerList.IndexOf(o);
        }

        public new void RemoveAt(int index)
        {
            InnerList.RemoveAt(index);
        }
    }
}
