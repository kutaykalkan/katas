using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryChop
{
    public class BinaryChop
    {
        public static int Search(int[] arr, int value) {
            if (arr == null)
                return -1;

            int minIndex = 0;
            int maxIndex = arr.Count() - 1;
            int currentIndex;

            while (minIndex <= maxIndex) {
                currentIndex = (minIndex + maxIndex) / 2; //(high + low) / 2
                if (arr[currentIndex] == value)
                    return currentIndex;
                else {
                    if (value < arr[currentIndex]) {
                        maxIndex = currentIndex - 1;
                    }
                    else
                        minIndex = currentIndex + 1;
                }
            }

            return -1;
        }

        public static int SearchRecursive(int[] arr, int value) {
            if (arr == null)
                return -1;

            int minIndex = 0;
            int maxIndex = arr.Length - 1;

            return Search(arr, value, minIndex, maxIndex);
        }

        private static int Search(int[] arr, int value, int min, int max) {
            int current = (min + max) / 2;
            if (min > max)
                return -1;

            if (value == arr[current])
                return current;

            if (value > arr[current])
                return Search(arr, value, current + 1, max);

            if (value < arr[current])
                return Search(arr, value, min, current - 1);

            return -1;
        }

        public static int SearchIterative2(int[] arr, int value) {
            // This implementation cannot return the correct index efficiently.
            if (arr == null)
                return -1;
            int currentIndex = (arr.Count() - 1) / 2;

            while (value != arr[currentIndex]) {
                int[] arrTemp = null;
                if (value < arr[currentIndex]) {
                    arrTemp = new int[currentIndex];
                    for (int i = 0; i < arrTemp.Count(); i++) {
                        arrTemp[i] = arr[i];
                    }
                }
                else if (value > arr[currentIndex]) {
                    arrTemp = new int[arr.Count() - 1 - currentIndex];
                    for (int i = currentIndex + 1, k = 0; i < arr.Count(); i++, k++) {
                        arrTemp[k] = arr[i];
                    }
                }
                if (arrTemp == null)
                    return -1;
                return Search(arrTemp, value);
            }

            return currentIndex;
        }
    }
}
