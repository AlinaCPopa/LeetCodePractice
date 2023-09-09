using MergeSortedArray;

// example 1
Console.WriteLine("Example 1");
var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
var nums2 = new int[] { 2, 5, 6 };
Solution.Merge(nums1, 3, nums2, 3);
Console.WriteLine();


// example 2
Console.WriteLine("Example 2");
nums1 = new int[] { 1 };
nums2 = new int[] { };
Solution.Merge(nums1, 1, nums2, 0);
Console.WriteLine();

// example 3
Console.WriteLine("Example 3");
nums1 = new int[] { 0 };
nums2 = new int[] { 1 };
Solution.Merge(nums1, 0, nums2, 1);
Console.WriteLine();
