using UnityEngine;

public class EliteEnemy : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Enemy Settings")]
    public Transform spriteTransform;
    public Color ColorChange;


    private void Update()
    {
        // Calculate the boundaries of my movement
        IncreasedSpriteSize();
        ChangeColor();
        float leftBoundary = startPos.x - patrolDistance;
        float rightBoundary = startPos.x + patrolDistance;

        transform.Translate(Vector2.right * direction * MoveSpeed * Time.deltaTime);

        // Flip this object when it hits a boundary
        if (transform.position.x >= rightBoundary)
        {
            direction = -1; // Go left
            transform.localScale = new Vector3(2,2,2);
        }
        else if (transform.position.x <= leftBoundary)
        {
            direction = 1;  // Go right
            transform.localScale = new Vector3(-2,2, 2);
        }
    }

    private void IncreasedSpriteSize()
    {
        Vector3 newScale = new Vector3(2, 2, 2);
        spriteTransform.localScale = newScale;
        Debug.Log("Doubled Sprite Size");


    }


}
