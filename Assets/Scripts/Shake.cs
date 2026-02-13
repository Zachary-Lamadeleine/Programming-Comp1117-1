using UnityEngine;
using Unity.Cinemachine;

public class Shake : MonoBehaviour
{
    private CinemachineImpulseSource impulse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        impulse = transform.GetComponent<CinemachineImpulseSource>();
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(impulse != null);

            Debug.Log("Triggered");
            impulse.GenerateImpulse();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

 
}
