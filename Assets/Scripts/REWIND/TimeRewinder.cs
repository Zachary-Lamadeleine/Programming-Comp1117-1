using UnityEngine;
using UnityEngine.InputSystem;

public class TimeRewinder : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private int maxFrames = 300;
    public bool isRewinding = false; //Public is Optional visual reference to know when you are rewinding

    private CircularBuffer intBuffer;

    private void Awake()
    {
        intBuffer = new CircularBuffer(maxFrames);
    }

    public void OnRewind(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            isRewinding = true;
            Debug.Log("RewindStarted");
            
        }
        else if(context.canceled)
        {
            isRewinding= false;
            Debug.Log("RewindStoped");
        }
    }

    private void Update()
    {
        if (!isRewinding)
        {
            Record();
        }
        else
        {
            Rewind();
        }
            
    }

    //Record - Records info every frame
    private void Record()
    {
        intBuffer.Push(Random.Range(0, 1000));
    }

    //Rewind - Retreives info every frame from the buffer
    private void Rewind()
    {
        int tempInt = intBuffer.Pop();
        Debug.Log ("Popped Value; " + tempInt);
    }

}
