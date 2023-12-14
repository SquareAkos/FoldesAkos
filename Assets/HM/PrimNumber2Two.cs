using UnityEngine;

public class PrimNumber2Two : MonoBehaviour
{
    [SerializeField] int number;


    void OnValidate()
    {
        bool primCheck = PrimChecker(number);
        if (primCheck == true & number > 0)
        {
            Debug.Log($"The {number} is a prime number");
        }
        else
            Debug.Log($"The {number} is not a prime number");
    }
    bool PrimChecker(int number)
    {
        int dividers = 0;
        for (int i = number; i > 0; i--)
        {
            float remainder = number % i;
            if (remainder == 0)
                dividers++;
            remainder = 0;
            if (dividers == 2)
                return true;
        }
        return false;
    }
}
