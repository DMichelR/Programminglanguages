using System;

namespace ConsoleApp1.May6;

public class ArrayRotation
{
    public static T[]? RotateRight<T>(T[]? array, int steps)
    {
        if (array == null || array.Length < 2)
        {
            return array;
        }

        var result = new T[array.Length];
        steps = steps % array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            result[(i + steps) % array.Length] = array[i];
        }

        return result;
    }
}