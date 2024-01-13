using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float acceleration = 5;
    [SerializeField] float angularSpeed = 360;
    [SerializeField] float gravity = 1;
    [SerializeField] float drag = 0.25f;


    Vector2 velocity = Vector2.zero;

    void FixedUpdate()
    {
        // Lövés
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("Pew!");

        // Acceleration
        float forwardInput = Input.GetAxisRaw("Vertical");

        Vector2 direction = (Vector2)transform.up;
        Vector2 accelerationVector = direction * forwardInput * acceleration;
        velocity += accelerationVector * Time.fixedDeltaTime;      // Hajtómû
        velocity += Vector2.down * gravity * Time.fixedDeltaTime;  // Gravitáció
        velocity = Vector2.ClampMagnitude(velocity, maxSpeed);

        // Drag
        Vector2 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;
    }

    void Update()
    {
        // Lövés
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("Pew!");

        // Movement
        transform.position += (Vector3)velocity * Time.deltaTime;

        // Rotation 
        float rotationInput = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, -rotationInput * angularSpeed * Time.deltaTime);
    }
}
