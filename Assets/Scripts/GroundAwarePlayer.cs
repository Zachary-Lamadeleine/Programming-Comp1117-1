using UnityEngine;

public class GroundAwarePlayer : MonoBehaviour
{
    [SerializeField] private LayerMask EnemyHeadLayer;
    [SerializeField] private Transform HeadCheck;     // Position of my ground check.
    [SerializeField] private float groundCheckRadius = 0.2f;    // Size of my ground check
    private bool isheadHit;
    private void Update() // Ground check
    {
        // Perform my ground check.
        
            isheadHit = Physics2D.OverlapCircle(HeadCheck.position, groundCheckRadius, EnemyHeadLayer);
        if (isheadHit)
            Destroy(gameObject);
    }
}
