using System;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int arrayLength;
    [SerializeField] int arrayMax;
    [SerializeField] int[] array1;
    [SerializeField] int[] array2;  
    [SerializeField] int[] array3;
    [SerializeField] int[] array4;

    void OnValidate()
    {
         array1 = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            array1[i] = i + 1;
        }

         array2 = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            array2[i] = arrayLength - i; 
        }
        
        
        array3 = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            
            array3[i] = (i + 1 )* 3;
        }



        int length = arrayMax / 3;

        array4 = new int[length];

        for (int i = 0; i < length; i++)
        {
            
            array4[i] = (i + 1 )* 3;
        }


        




       
        
    }

    
}
