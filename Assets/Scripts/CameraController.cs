using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;

    public Vector3 smoothSpeed = new Vector3(0, 0, 2);
    public float smoothTime = 0.5f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref smoothSpeed, smoothTime);
        transform.position = smoothedPosition;
    }
}