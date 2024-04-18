using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1;
internal class Actions<T>
{
    public void Upper(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i].ToUpper();
        }
    }

    public void PlusOne(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int value = Convert.ToInt32(array[i]) + 1;
            array[i] = (T)(object)value;
        }
    }
}
