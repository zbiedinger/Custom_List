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
        public bool Add(T valueToAdd)
        {
            bool couldAdd = false;
            
            if(count < capacity)
            {
                _items[count] = valueToAdd;
                count++;
                couldAdd = true;
            }
            else
            {
                capacity *= 2;
                T[] temp = new T[capacity];

                for (int i = 0; i < count-1; i++)
                {
                    temp[i] = _items[i];
                }

                _items = new T[capacity];

                for (int i = 0; i < count - 1; i++)
                {
                    _items[i] = temp[i];
                }

                temp[count] = valueToAdd;
                count++;
                couldAdd = true;
            }
            
            return couldAdd;
        }

        public bool Remove(T valueToRemove)
        {
            bool couldRemove = true;

            count--;
            return couldRemove;
        }

    }
}
