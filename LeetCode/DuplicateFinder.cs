using System;
using System.Collections.Generic;
public class DuplicateFinder
{
    public static int[] FindDuplicates(int[] nums)
    {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        List<int> duplicates = new List<int>();
        foreach (int num in nums)
        {
            if (countMap.ContainsKey(num))
            {
                countMap[num]++;
            }
            else
            {
                countMap[num] = 1;
            }
        }
        foreach (var kvp in countMap)
        {
            if (kvp.Value == 2)
            {
                duplicates.Add(kvp.Key);
            }
        }
        return duplicates.ToArray();
    }
}