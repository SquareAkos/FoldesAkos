using UnityEngine;

class Explosion : MonoBehaviour
{
    [SerializeField] float range = 10;
    [SerializeField] float maxImpulse = 100;
    [SerializeField] float upwardMod = 1;
    [SerializeField] new Renderer renderer;
    [SerializeField] ParticleSystem particleEffect;
    [SerializeField] AudioSource audioEffect;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
        // Ray r = new (transform.position, transform.forward);

        bool isHit = Physics.Raycast(mouseRay, out RaycastHit hitInfo);
        renderer.enabled = isHit;

        if (isHit)
        {
            // Történt találat
            Vector3 position = hitInfo.point;
            transform.position = position;

            // Input.GetKeyDown(KeyCode.Mouse0);
            if (Input.GetMouseButtonDown(0))
            {
                StartExplosion();
            }
        }
    }

    void StartExplosion()
    {
        particleEffect.Play();
        audioEffect.Play();
        Rigidbody[] allRigidBodies = FindObjectsOfType<Rigidbody>();

        Vector3 center = transform.position;

        foreach (Rigidbody rb in allRigidBodies)
        {
            rb.AddExplosionForce(maxImpulse, center, range, upwardMod, ForceMode.Impulse);

            /*
            Vector3 p = rb.position;
            Vector3 distanceVector = p - center;
            float distance = distanceVector.magnitude;
            if (distance >= range) continue;

            // Vector3 direction = distanceVector.normalized;
            Vector3 direction = distanceVector / distance;

            float pushRate = 1 - (distance / range);

            Vector3 push = pushRate * maxImpulse * direction;
            rb.velocity += push / rb.mass;

            // rb.AddForce(push, ForceMode.Impulse);  // Mindjárt...
            */
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
