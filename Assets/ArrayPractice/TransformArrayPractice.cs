using UnityEngine;

public class TransformArrayPractice : MonoBehaviour
{
    [SerializeField] Transform[] transforms;
    
    

    
    void Update()
    {
        if (transforms.Length < 3) return;

        Vector3 p0 = transforms[0].position;
        
        Vector3 plast = transforms[transforms.Length-1].position; // 

        for (int i = 1; i < transforms.Length -1 ; i++)
        {
            Transform t = transforms[i];
            float rate = (float) i / (transforms.Length -1);
            Vector3 p = Vector3.Lerp(p0, plast, rate);
            t.position = p;
        }
        
        
    }
}
