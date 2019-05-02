using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpRef
{
    public static class DataUpdateManager
    {
        
        public static void SetDefault<T>(T obj)
        {
            obj = default(T);
        }
        public static void SetDefault<T>(ref T obj)
        {
            obj = default(T);
        }
        public static void UpdateName<T>(T obj, string name) where T: IName
        {
            obj.UpdateName(name);
        }
        public static void UpdateName<T>(ref T obj, string name) where T : IName
        {
            obj.UpdateName(name);
        }
        public static void UpdateValue<T>(ref T left, T right)
        {
            left = right;
        }
        public static void UpdateValue<T>(T left, T right)
        {
            left = right;
        }

        public static void UpdateStart<T>(T obj, Point point) where T: IShape
        {
            obj.Start = point;
        }

        public static void InitArray<T>(T[] array , T value)
        {
           for(int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }
        public static void InitArray<T>(ref T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }
        public static ref T GetNthElement<T>(T[] array, int No)
        {
            return ref array[No];
        }


       


    }
}
