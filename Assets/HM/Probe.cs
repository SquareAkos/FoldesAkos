
using UnityEngine;

public class Probe : MonoBehaviour
{
    [SerializeField] int a, b, c;
    void Start()
    {
        float sumNumbers = a + b + c;
        int maxNumber = Mathf.Max(a, b, c);
        if (maxNumber <= 200)
        {
            int minNumber = Mathf.Min(a, b, c);
            float squareMin = Mathf.Pow(minNumber, 2);
            float squareMax = Mathf.Pow(maxNumber, 2);
            float minAndMax = maxNumber + minNumber;
            float centerNumber = sumNumbers - minAndMax;
            float squareCenter = Mathf.Pow(centerNumber, 2);
            float smallerSquares = squareMin + squareCenter;
            if (smallerSquares == squareMax)
            {
                Debug.Log("The tree number is pitagoras numbers");
            }
            else
                Debug.Log("The numbers is not pitaogras numbers");
            Debug.Log(squareMin);
            Debug.Log(squareCenter);
            Debug.Log(squareMax);
        }
        else
            Debug.Log("The numbers is not pitaogras numbers");
        
    }
    
}
