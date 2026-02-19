using System.Collections;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class GemTracking : MonoBehaviour
{

    private Rigidbody2D rigidBody;
    public GameObject targetPlayer;
    public float homingSpeed = 5f;
    private bool TrackTargetTrue = false;
    public GameObject Gem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        targetPlayer = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(StartTracking());
    }

    private IEnumerator StartTracking()
    {

        yield return new WaitForSeconds(3f);
        TrackTargetTrue = true;
    }
    private void TrackTarget()
    {
        if (TrackTargetTrue == true)
        {
            rigidBody = GetComponent<Rigidbody2D>();

            Vector3 TrackDirection = targetPlayer.transform.position - transform.position;
            rigidBody.linearVelocity = new Vector2(TrackDirection.x, TrackDirection.y).normalized * homingSpeed;
        }
        
    }

    private void Update()
    {
        TrackTarget();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(Gem);
        }
    }



}
