using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSnake : MonoBehaviour
{
    [SerializeField]
    public float Speed;
    public static float SpeedSnake;
    public GameObject toObject;
    void FixedUpdate()
    {
        SpeedSnake = Speed;
        transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(0f,0f,1f), SpeedSnake * Time.deltaTime);
       
    }
}
