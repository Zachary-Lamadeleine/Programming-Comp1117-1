using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpeedBoost : MonoBehaviour
{
    public float boostSpeed;
    private float savedSpeed;
    public PlayerStats stats;
    public float boostDuration;
    public Vector2 targetPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            //savedSpeed = stats.moveSpeed;
            //stats.moveSpeed = boostSpeed;
            StartCoroutine(BoostTimer());
            Debug.Log("speed increase");
            transform.position = new Vector2(99999999f, 999999999f);

        }
    }


    IEnumerator BoostTimer()
    {
        yield return new WaitForSeconds(boostDuration);
        //stats.moveSpeed = savedSpeed;
        Debug.Log("speed reset");
        Destroy(gameObject);
    }










}
