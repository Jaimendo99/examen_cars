using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 100.0f;
    public Rigidbody rb;
    // Initial and maximum speeds
    float initialSpeed = 10.0f;
    float maxSpeed = 40.0f;
    float acceleration = 5.0f;
    float speed = 10.0f;

// Timer to track how long the forward key is held down
    float holdTimer = 0.0f;

    void Update()
    {
        // Check for forward key press
        float moveVertical = Input.GetAxis("Vertical");

        if (moveVertical > 0)
        {
            // Increase hold timer while the forward key is pressed
            holdTimer += Time.deltaTime;

            // Limit speed to maxSpeed
            float newSpeed = initialSpeed + (acceleration * holdTimer);
            speed = Mathf.Clamp(newSpeed, initialSpeed, maxSpeed);

            // Calculate movement vector
            Vector3 movement = transform.forward * speed;

            // Apply velocity-based movement
            rb.velocity = movement;
        }
        else
        {
            // Reset hold timer when the key is released
            holdTimer = 0.0f;

            // Stop the object when not moving forward
            rb.velocity = Vector3.zero;
        }
        
        // Rotación
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, rotation,0);

    }
}
