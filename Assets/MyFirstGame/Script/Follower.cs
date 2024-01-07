using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] Transform targetTrasnform;
    void Update()
    {
        Vector3 selfPosition = transform.position;
        Vector3 targetPosiion = targetTrasnform.position;

        transform.position = Vector3.MoveTowards(selfPosition,targetPosiion,speed * Time.deltaTime);


        Vector3 directionvector = targetPosiion - selfPosition;
        directionvector.Normalize();

        //Vector3 velocityVector = directionvector * speed;
        //transform.position += velocityVector * Time.deltaTime;

        

        if (directionvector != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(directionvector);
        
    }
}
