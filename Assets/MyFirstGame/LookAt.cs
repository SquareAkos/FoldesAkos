using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Transform target;

    
    void Update()
    {
        transform.LookAt(target);

        //Vector3 lookDir = target.position - transform.position;
        //transform.rotation = Quaternion.LookRotation(lookDir);

        
    }
}
