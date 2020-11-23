using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListZ
{
    public class CustomList<T>
    {
        //Member Variables
        T[] _items;
        public int count;
        public int capacity;

        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }

        //Member Methods
        public void Add(T valueToAdd)
        {
            _items[count] = valueToAdd;
            count++;

        }

    }
}
