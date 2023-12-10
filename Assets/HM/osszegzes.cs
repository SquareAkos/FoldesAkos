using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class osszegzes : MonoBehaviour
{
    [SerializeField] int Number = 1;
    [SerializeField] int summa = 0;
    void OnValidate()
    {
        summa = 0;
        int i = Number;
        for (int a = 0; a <= i; a++)
        {
            summa += a;
        }
        Debug.Log(summa);
    }
    
}
