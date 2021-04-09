using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float maxSpeed;
    public float acceleration;
    public float steering;
    private Vector2 movementInput;
    private Rigidbody2D rb;
    private float currentSpeed;
    public Canvas canvas;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame


    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }


    public void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.CompareTag("Obstacle"))
        {

            
            Destroy(gameObject, .5f);
            SceneManager.LoadScene(2, LoadSceneMode.Single);

        }
    }

    private void FixedUpdate()
    {
        // Get input
        float h = -movementInput.x;
        float v = movementInput.y;

        // Calculate speed from input and acceleration (transform.up is forward)
        Vector2 speed = transform.up * (v * acceleration);
        rb.AddForce(speed);

        // Create car rotation
        float direction = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up));
        if (direction >= 0.0f)
        {
            rb.rotation += h * steering * (rb.velocity.magnitude / maxSpeed);
        }
        else
        {
            rb.rotation -= h * steering * (rb.velocity.magnitude / maxSpeed);
        }

        

        // Change velocity based on rotation
        float driftForce = Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.left)) * 2.0f;
        Vector2 relativeForce = Vector2.right * driftForce;
        Debug.DrawLine(rb.position, rb.GetRelativePoint(relativeForce), Color.green);
        rb.AddForce(rb.GetRelativeVector(relativeForce));

        // Force max speed limit
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
        currentSpeed = rb.velocity.magnitude;
    }



}
