using UnityEngine;

class Calculator : MonoBehaviour
{
    [SerializeField] float a, b;

    [SerializeField] float sum;
    [SerializeField] float difference;
    [SerializeField] float product;
    [SerializeField] float rate;

    void Start()
    {
        sum = a + b;
        difference = a - b;
        product = a * b;
        rate = a / b;

    }
}
