using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiply : MonoBehaviour
{
    

    int a = 1; int sum;
    void Start()
    {
        while (a < 11)
        {
            for (int i = 1; i < 11; i++)
            {
                sum = a * i;
                Debug.Log(i + ("*") + a + ("=") + sum);
            }
            a++;
        }
    }
}

