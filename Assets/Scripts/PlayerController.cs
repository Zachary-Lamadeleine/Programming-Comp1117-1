using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Range(0.0f, 20.0f)]
    public float speed;
    [SerializeField] private Rigidbody2D playerRigidBody;

    //components
    Rigidbody2D rBody;

    //private Variables
    Vector2 moveInput;
    Vector2 jumpInput;

    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value)
    {
        jumpInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        ApplyMovement();
    }

    void ApplyMovement()
    {
        float targetVelocityX = moveInput.x * speed;
        rBody.linearVelocity = new Vector2(targetVelocityX, rBody.linearVelocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            float targetVelocityY = jumpInput.y * speed;
            rBody.linearVelocity = new Vector2(targetVelocityY,rBody.linearVelocityX);
        }
    }


}
