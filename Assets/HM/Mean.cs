using UnityEngine;

class Mean : MonoBehaviour
{
    [SerializeField] int a, b, c, d, e;
    [SerializeField] float mean;

    void OnValidate()
    {
        mean = (a + b + c + d + e) / 5f;
    }

}
