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

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                _items[index] = value;
            }
        }

        //Member Methods
        //Add method using arrays
        public bool Add(T valueToAdd)
        {
            bool couldAdd = false;

            if (count < capacity)
            {
                _items[count] = valueToAdd;
                count++;
                couldAdd = true;
            }
            else
            {
                capacity *= 2;
                T[] temp = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    temp[i] = _items[i];
                }

                _items = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    _items[i] = temp[i];
                }

                _items[count] = valueToAdd;
                count++;
                couldAdd = true;
            }

            return couldAdd;
        }

        public bool Remove(T valueToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(valueToRemove, _items[i]))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        _items[j] = _items[j + 1];
                    }

                    T[] temp = new T[capacity];

                    for (int j = 0; j < count - 1; j++)
                    {
                        temp[j] = _items[j];
                    }

                    _items = new T[capacity];

                    for (int j = 0; j < count; j++)
                    {
                        _items[j] = temp[j];
                    }

                    count--;
                    return true;
                }
            }
            return false;
        }

    }
}

