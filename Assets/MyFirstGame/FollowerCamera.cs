using UnityEngine;

class FollowerCamera : MonoBehaviour
{
    [SerializeField] Transform followed;
    [SerializeField] float range = 2;

    Vector3 offsetVector;

    void Start()
    {
        offsetVector = transform.position - followed.position;
    }

    void Update()
    {
        transform.position = followed.position + offsetVector;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position - offsetVector, range);
    }
}
