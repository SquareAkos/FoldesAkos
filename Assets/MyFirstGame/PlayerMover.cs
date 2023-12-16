using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] Transform cameraTransform;
    [SerializeField] float speed;

    void OnValidate()
    {
        if (cameraTransform == null)        
            cameraTransform = Camera.main.transform;
        
        
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        

        Vector3 cameraForward = cameraTransform.forward;
        Vector3 cameraRight = cameraTransform.right;

        Vector3 directionVector = cameraRight * x + cameraForward * z;
        directionVector.y = 0;
        // Vector3 directionVector = new(x,0,z); // globális
        directionVector.Normalize();
        Vector3 velocityVector = directionVector * speed;

        transform.position += velocityVector * Time.deltaTime;



        if (directionVector != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(directionVector);
        }
        


        
    }
}
