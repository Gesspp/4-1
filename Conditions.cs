using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1;
sealed internal class Conditions<T>
{
    public bool LengthFive(T el)
    {
        try
        {
            if (el != null)
            {
                if (el.ToString().Length > 5)
                {
                    return true;
                }
                return false;
            }
            else { return false; }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public bool IsVowel(T el)
    {
        string chars = "аеёиоуыэюяaeiouy";

        foreach (char c in chars)
        {
            try
            {
                if (el != null)
                {
                    if (c.ToString() == el.ToString().ToLower())
                    {
                        return true;
                    }
                }
                else { return false; }
            }
            catch
            {
                return false;
            }
        }
        return false;
    }

    public bool IsEven(T el)
    {
        if (typeof(T) == typeof(int) | typeof(T) == typeof(double)) { return Convert.ToInt32(el) % 2 == 0; }
        return false;
    }


}