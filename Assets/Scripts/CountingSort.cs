using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CountingSort : MonoBehaviour
{
    [SerializeField] private int[] array;
    
    [ContextMenu("Sort")]
    public void Sort()
    {
        string arrayString = null;
        int[] sortArray = SortArray(array);
        foreach (int num in sortArray)
        {
            arrayString += $"{num} ";
        }
        Debug.Log(arrayString);
    }
    
    public int[] SortArray(int[] inputArray)
    {
        int[] countArray = new int[inputArray.Max() + 1];
        for (int i = 0; i < inputArray.Length; i++)
        {
            countArray[inputArray[i]]++;
        }
        int[] sortedArray = new int[inputArray.Length];
        int sortedArrayIndex = 0;
        for (int i = countArray.Length-1; i >=0; i--)
        {
            for (int j = 0; j < countArray[i]; j++)
            {
                sortedArray[sortedArrayIndex] = i;
                sortedArrayIndex++;
            }
        }
        return sortedArray;
    }
}
