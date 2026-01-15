using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpeedBoost : MonoBehaviour
{
        public float boostSpeed;
        private float savedSpeed;
        public PlayerController controller;
        public float boostDuration;
        public Vector2 targetPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag == "Player")
            {
                
                savedSpeed = controller.speed;
                controller.speed = boostSpeed;
                StartCoroutine(BoostTimer());
                Debug.Log("speed increase");
                transform.position = new Vector2(99999999f, 999999999f);

        }
    }


    IEnumerator BoostTimer()
    {
        yield return new WaitForSeconds(boostDuration);
        controller.speed = savedSpeed;
        Debug.Log("speed reset");
        Destroy(gameObject);
    }
       






}
