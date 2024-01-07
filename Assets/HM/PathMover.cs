using UnityEngine;

class PathMover : MonoBehaviour
{
    [SerializeField] Transform t1, t2;
    [SerializeField] float speed;
    [SerializeField, Range(0, 1)] float startPoint;
    Transform currentTarget;

    void OnValidate()
    {
        transform.position = Vector3.Lerp(t1.position, t2.position, startPoint);
    }
    void Start()
    {
        transform.position = t1.position;
        currentTarget = t2;
    }
    void Update()
    {
        Vector3 targetPoint = currentTarget.position;
        Vector3 currentPoint = transform.position;
        transform.position =
            Vector3.MoveTowards(currentPoint, targetPoint, speed * Time.deltaTime);

        if (transform.position == targetPoint)
        {
            currentTarget = currentTarget == t1 ? t2 : t1;
        }
        
    }
    void OnDrawGizmos()
    {
        if (t1 == null || t2 == null) return;

        Vector3 p1 = t1.position;
        Vector3 p2 = t2.position;

        Gizmos.color = Color.green;
        Gizmos.DrawSphere(p1, 0.2f);
        Gizmos.DrawLine(p1, p2);
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(p2, 0.2f);
    }
}
