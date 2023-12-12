using UnityEngine;

public class abs : MonoBehaviour
{

    void Start()
    {
        float test = Floorown(-13.9f);
        Debug.Log(test);
    }
    float Floorown(float floornumber)
    {
        int helpvar = (int)floornumber; return helpvar;
    }
}
