using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListZ
{
    public class CustomList<T> : IEnumerable, IComparable
    {
        //Member Variables
        int count;
        int capacity;
        public T[] _items;
        

        //Properties
        //count is read only
        public int Count { get => count; }
        
        //capacity is read only
        public int Capacity
        {
            get => capacity;
        }
        
        //indexer
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                _items[index] = value;
            }
        }


        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }
      

        //Member Methods
        //Add a passed in value to the custom list
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

        //remove a passed in value to the custom list
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

        //override the ToString method
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                builder.Append(_items[i]);
            }
            
            string nowstring = builder.ToString();
            return nowstring;
        }

        //Overload the plus operator
        public static CustomList<T> operator +(CustomList<T> _listOne, CustomList<T> _listTwo)
        {
            CustomList<T> _newList = new CustomList<T>();

            for (int i = 0; i < _listOne.count; i++)
            {
                _newList.Add(_listOne[i]);
            }
            for (int i = 0; i < _listTwo.count; i++)
            {
                _newList.Add(_listTwo[i]);
            }

            return _newList;
        }

        //Overload the minus operator
        public static CustomList<T> operator -(CustomList<T> _originalList, CustomList<T> _listToSubtract)
        {
            CustomList<T> _newList = _originalList;

            for (int i = 0; i < _listToSubtract.Count; i++)
            {
                for (int j = 0; j < _originalList.Count; j++)
                {
                    if (_listToSubtract[i].ToString() == _originalList[j].ToString())
                    {
                        _newList.Remove(_originalList[j]);
                        break;
                    }
                }
            }
            return _newList;
        }

        //Zip method that passes in a list to be zipped with
        public CustomList<T> Zip(CustomList<T> passedList)
        {
            CustomList<T> zippedList = new CustomList<T>();

            if (Count == passedList.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    zippedList.Add(_items[i]);
                    zippedList.Add(passedList[i]);
                }
            }
            else if(Count < passedList.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    zippedList.Add(_items[i]);
                    zippedList.Add(passedList[i]);
                }
                for (int i = Count; i < (passedList.Count); i++)
                {
                    zippedList.Add(passedList[i]);
                }
            }
            else if(Count > passedList.Count)
            {
                for (int i = 0; i < passedList.Count; i++)
                {
                    zippedList.Add(_items[i]);
                    zippedList.Add(passedList[i]);
                }
                for (int i = passedList.Count; i < (Count); i++)
                {
                    zippedList.Add(_items[i]);
                }
            }
            return zippedList;
        }

        //contract for IEnumerable
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _items[i];
            }
        }

        public void Sort()
        {
            //T[] temp = new T[Count];
            //int position = Count-1;
            //for (int i = 0; i < Count; i++)
            //{
            //    temp[i] = _items[position];
            //    position--;
            //}
            //_items = temp;
        }

        //Contract for Icomparable
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();

        }

        //public int CompareTo(CustomList<T> actual)
        //{
        //    int result = -1;

        //    if (Count == actual.Count)
        //    {
        //        for (int i = 0; i < Count; i++)
        //        {
        //            //if(_items[i] == actual[i])
        //            //{

        //            //}
        //            //else
        //            //{
        //            //    result = -1;
        //            //}
        //        }
        //        result = 0;
        //    }
        //    else if (Count < actual.Count)
        //    {
        //        result = 1;
        //    }
        //    else if (Count < actual.Count)
        //    {
        //        result = -1;
        //    }

        //    return result;





        //    char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        //    for (int i = 1; i < 21; i++)
        //    {
        //        {
        //            //newBoard[0, i] = "  " + alpha[i - 1];
        //        }
        //    }
        //}
    }
}

