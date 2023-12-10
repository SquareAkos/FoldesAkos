using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueSwitch : MonoBehaviour
{
    [SerializeField] string a, b;
    void Start()
    {
        string temp = a;
        a = b;
        b = temp;

    }

}
