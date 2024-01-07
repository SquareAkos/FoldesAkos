
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float maxDistance = 10;

    Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        // movement forward
        transform.position += transform.forward * speed * Time.deltaTime;

        //delete
        float currentDistance = Vector3.Distance(startPosition, transform.position);

        if (currentDistance >= maxDistance)
            Destroy(gameObject);

    }
}
