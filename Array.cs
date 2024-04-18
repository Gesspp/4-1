using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1;
public class LineArray<T>
{
    private T[] array;

    public LineArray(bool isDefault)
    {

    }

    public T[] DefaultArray()
    {
        array = new T[7];
        return array;
    }

    public T[] LengthArray(int length)
    {
        array = new T[length];
        return array;
    }

    public int LengthCounter()
    {
        return array.Length;
    }

    public void ArraySort()
    {
        Array.Sort(array);
    }

    public void PrintArray()
    {
        foreach (T item in array)
        {
            Console.Write(item + " ");
        }
    }

    public bool IsElementInArray(T el)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if ((object)array[i] == (object)el)
            {
                return true;
            }
        }
        return false;
    }

    public bool ArrayAppend(T el)
    {
        for (int i = 0; i < array.Length; i++)
        {
            try
            {
                if (array[i] == null | Convert.ToInt32(array[i]) == 0)
                {
                    array[i] = el;
                    return true;
                }
            }
            catch
            {
                if (array[i] == null)
                {
                    array[i] = el;
                    return true;
                }
            }

        }
        Array.Resize(ref array, array.Length * 2 + 1);
        return true;
    }

    public int ElementsCount()
    {
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            cnt++;
        }
        return cnt;
    }

    public void ArrayReverse()
    {
        Array.Reverse(array);
    }

    public void DeleteElement(T el)
    {

        int idx = Array.IndexOf(array, el);
        T[] newArray = new T[array.Length - 1];

        for (int i = 0; i < idx; i++)
        {
            if (i != idx)
            {
                newArray[i] = array[i];
            }
        }

        for (int i = idx + 1; i < array.Length; i++)
        {
            newArray[i - 1] = array[i];
        }

        array = newArray;
    }

    public void FindMax()
    {
        T max = array[0];
        foreach (T item in array)
        {
            try
            {
                if (Convert.ToInt32(item) > Convert.ToInt32(max))
                {
                    max = item;
                }
            }
            catch
            {
                Console.WriteLine("невозможно выполнить функцию");
                return;
            }


        }

        Console.WriteLine(max);
    }

    public void FindMin()
    {
        T min = array[0];
        foreach (T item in array)
        {
            try
            {
                if (Convert.ToInt32(item) < Convert.ToInt32(min))
                {
                    min = item;
                }
            }
            catch
            {
                Console.WriteLine("невозможно выполнить функцию");
                return;
            }
        }

        Console.WriteLine(min);
    }

    public void ConditionElementCount(Func<T, bool> con)
    {
        int cnt = 0;
        foreach (T el in array)
        {
            if (con(el))
            {
                cnt++;
            }
        }

        Console.WriteLine(cnt);
    }

    public void OneElementCondition(Func<T, bool> con)
    {
        int cnt = 0;
        foreach (T el in array)
        {
            if (con(el))
            {
                cnt++;
            }
        }

        if (cnt > 0)
        {
            Console.WriteLine("true");
            return;
        }
        else
        {
            Console.WriteLine("false");
            return;
        }
    }

    public void AllElementsCondition(Func<T, bool> con)
    {
        int cnt = 0;

        foreach (T el in array)
        {
            if (con(el))
            {
                cnt++;
            }
        }
        if (cnt == array.Length)
        {
            Console.WriteLine("true");
            return;
        }
        else
        {
            Console.WriteLine("false");
            return;
        }
    }
    public T GetFirstEl(Func<T, bool> con)
    {
        foreach (T el in array)
        {

            if (con(el))
            {
                return el;
            }
        }
        return default(T);
    }

    public void ProectEl()
    {
        try
        {
            if (typeof(T) == typeof(int) | typeof(T) == typeof(int) | typeof(T) == typeof(bool))
            {
                foreach (T el in array)
                {
                    Console.Write(el.ToString() + " ");
                }

            }
            else if (typeof(T) == typeof(string))
            {
                foreach (T el in array)
                {
                    Console.Write(Convert.ToInt32(el) + " ");
                }
            }
        }
        catch
        {
            throw new Exception("не удалось спроецировать");
        }
    }
    public void MakeAction(Func<T, bool> act)
    {
        for (int i = 0; i < array.Length; i++)
        {
            try
            {
                act(array[i]);
                Console.WriteLine("действие применено");
            }
            catch
            {
                throw new Exception("невозможно выполнить действие");
            }
        }
    }

    internal void MakeAction(Action<string[]> upper)
    {
        throw new NotImplementedException();
    }

    internal void MakeAction<T>(Action<T[]> plusOne)
    {
        throw new NotImplementedException();
    }
}
