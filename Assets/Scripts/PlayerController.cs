using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Range(0.0f, 20.0f)]
    public float speed = 10.0f;

        //components
    Rigidbody2D rBody;

    //private Variables
    Vector2 moveInput;

    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        ApplyMovement();
    }

    private void ApplyMovement()
    {
        float targetVelocityX = moveInput.x * speed;

        rBody.linearVelocity = new Vector2(targetVelocityX, rBody.linearVelocity.y);
    }
}
