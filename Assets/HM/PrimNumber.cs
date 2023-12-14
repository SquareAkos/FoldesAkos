using UnityEngine;

public class PrimNumber : MonoBehaviour
{
    [SerializeField] int number;
    
        void OnValidate()
    {
        
        int hanySzammalOsztahto = 0;
        for (int i = number; i > 0; i--)
        {
            float maradek = number % i;
            if (maradek == 0)
                hanySzammalOsztahto++;
            maradek = 0;
        }
        if (hanySzammalOsztahto == 2)
            Debug.Log("prim szam");
        
        else
            Debug.Log("not prim szam");
    }
}
