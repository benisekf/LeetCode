using System;
class Program
{
    static void Main()
    {
        int[] nums1 = { 0, 1, 1, 0 };
        int[] nums2 = { 0, 3, 2, 1, 3, 2 };
        int[] nums3 = { 7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2 };

        Console.WriteLine($"Output: [{string.Join(", ", DuplicateFinder.FindDuplicates(nums1))}]");
        Console.WriteLine($"Output: [{string.Join(", ", DuplicateFinder.FindDuplicates(nums2))}]");
        Console.WriteLine($"Output: [{string.Join(", ", DuplicateFinder.FindDuplicates(nums3))}]");
    }
}
