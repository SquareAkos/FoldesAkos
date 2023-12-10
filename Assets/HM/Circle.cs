using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] float circumference, area;

     void OnValidate()
    {
        float pi = Mathf.PI;
        circumference = 2 * radius * pi;
        area = radius * radius * pi;
    }
}
