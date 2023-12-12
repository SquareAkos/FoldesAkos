using UnityEngine;

public class abs : MonoBehaviour
{

    void Start()
    {
        float testfloor = Floorown(-13.9f);
        float t2floor = Mathf.Floor(-13.9f);
        float testCeil = Ceiling(12.7f);
        float originceil = Mathf.Ceil(12.7f);
        Debug.Log(testfloor);
        Debug.Log(t2floor);
    }
    float Floorown(float floornumber)
    {
        int helpvar = (int)floornumber;
        if (helpvar < 0) helpvar--;
        return helpvar;
    }

    float Ceiling(float ceilingnumber)
    {
        int helpvar = (int)ceilingnumber;
        if (helpvar > 0) helpvar++;
        return helpvar;    
    }
}
