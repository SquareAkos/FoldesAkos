using UnityEngine;

public class Homework : MonoBehaviour
{
    void Start()
    {
        float floorTest1 = FloorOwn(13.9f);
        float originalFloor = Mathf.Floor(13.9f);
        float testCeil = CeilingOwn(12.7f);
        float originalCeil = Mathf.Ceil(12.7f);
        Debug.Log(floorTest1);
        Debug.Log(originalFloor);
        Debug.Log(testCeil);
        Debug.Log(originalCeil);
    }
    float FloorOwn(float floorTest1)
    {
        int helpVar = (int)floorTest1;
        if (helpVar < 0) 
            helpVar--;
        return helpVar;
    }

    float CeilingOwn(float testCeil)
    {
        int helpVar = (int)testCeil;
        if (helpVar > 0) 
            helpVar++;
        return helpVar;    
    }
}
