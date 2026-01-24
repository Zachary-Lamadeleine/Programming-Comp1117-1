using System;
using UnityEngine;

/// <Referenc>
/// https://www.bing.com/videos/search?q=unity+2d+how+to+make+a+moving+platform&&view=detail&mid=191ECF7EF53BFA9058A7191ECF7EF53BFA9058A7&FORM=VAMGZC
/// </summary>
public class MovingPlatform : MonoBehaviour
{
    private Vector3 LocationA;
    private Vector3 LocationB;
    private Vector3 NextLocation;

    [SerializeField] private Transform Platform;
    [SerializeField] private Transform MovingToLocation;
    //tart is called before the first frame update

    public float Speed;
    


    private void Start()
    {
        LocationA = Platform.localPosition;
        LocationB = MovingToLocation.localPosition;
        NextLocation = LocationB;

    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Platform.localPosition = Vector3.MoveTowards(Platform.localPosition, NextLocation, Speed * Time.deltaTime);

        if (Vector3.Distance(Platform.localPosition,NextLocation) <= 0.1)
        {
            ChangePosition();
        }
    }

    private void ChangePosition()
    {
        NextLocation = NextLocation != LocationA ? LocationA : LocationB;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
