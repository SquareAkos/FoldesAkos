using System;
using Unity.VisualScripting;
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

        //void Start()
        //{

        //    Reverse(array1);

        //}


        void Reverse(int[] numbers)

        {

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int a = numbers[i];
                int b = numbers[^(1 + i)];

                numbers[i] = b;
                numbers[^(i + 1)] = a;
            }

        }




       
        
    }

    
}
