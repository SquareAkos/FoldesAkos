using UnityEngine;

class AutoRotate : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360;

    void Update()
    {
        float rotateInAngle = angularSpeed * Time.deltaTime;
        transform.Rotate(0, rotateInAngle, 0);

        /*
        Quaternion rotation = transform.rotation;
        Vector3 rotationInEuler = rotation.eulerAngles;
        rotationInEuler.y += angularSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotationInEuler);
        */
    }
}
