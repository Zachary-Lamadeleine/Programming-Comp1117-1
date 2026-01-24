using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Enemy : Character
{
    [Header("Enemy Settings")]
    [SerializeField] private float patrolDistance = 5.0f;
    private Rigidbody2D rBody;
    protected override void Awake()
    {
        base.Awake();
        rBody = GetComponent<Rigidbody2D>();
        Debug.Log("Awake in Enemy.cs");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //If player touches object, destroy what  is taged to it.
        if (collision.gameObject.tag == "Player")
        {
            //Bullet Audio
            
            Destroy(gameObject);
        }
    }
}
