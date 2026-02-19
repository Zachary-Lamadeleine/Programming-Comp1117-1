using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;


public class PressurePlate : MonoBehaviour
{
    //public GameObject TileMap;
    public GameObject Door;
    
    //[SerializeField] private UnityEvent onActivated;
    //public bool isFlipped = false;
  
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //If object touches object, destroy what  is taged to it.
        if (collision.gameObject.tag == "Pushable")
        {
            StartCoroutine(WAIT());
            
            //Interact();
        }
    }

    private IEnumerator WAIT()
    {

        yield return new WaitForSeconds(2f);
        //TileMap.SetActive(false);
        Destroy(Door);
    }

    //public void Interact()
    //{
    //    isFlipped = !isFlipped; // Flips isFlipped


    //    if (isFlipped)
    //    {
    //        onActivated.Invoke();
    //    }
    //}
}
