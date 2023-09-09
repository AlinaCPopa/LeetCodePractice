using Console = System.Console;

namespace MergeSortedArray
{
    internal static class Solution
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var firstArray = new int[m];
            Array.Copy(nums1, firstArray, m);
            Console.WriteLine($"first array is {string.Join(", ", firstArray)}");
            var temp = MergeTwoArrays(firstArray, nums2);

            for (int i = 0; i < temp.Length; i++)
            {
                nums1[i] = temp[i];
            }
        }

        private static int[] MergeTwoArrays(int[] a, int[] b)
        {
            var merged = new int[a.Length + b.Length];
            var i = 0;
            var j = 0;
            var k = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    Console.WriteLine($"Adding {a[i]} to merged.");
                    merged[k++] = a[i++];
                }
                else
                {
                    Console.WriteLine($"Adding {b[j]} to merged.");
                    merged[k++] = b[j++];
                }
            }

            while (i < a.Length)
            {
                Console.WriteLine($"Adding {a[i]} to merged.");
                merged[k++] = a[i++];
            }

            while (j < b.Length)
            {
                Console.WriteLine($"Adding {b[j]} to merged.");
                merged[k++] = b[j++];
            }

            return merged;
        }
    }
}
