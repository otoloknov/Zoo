using System;
using System.Collections.Generic;


namespace ZooLibrary
{
    public class CageTemplate <T>
    {
        private readonly List<T> _cageList = new List<T>();

        public void AddToCage(T item)
        {
            _cageList.Add(item);
        }

        public void PrintAll()
        {
            foreach (var cage in _cageList)
            {
                Console.WriteLine(cage.ToString());
            }
        }
    }
}