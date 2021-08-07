using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePartSnake : MonoBehaviour
{
    public GameObject toObject;

    private void FixedUpdate()
    {
        transform.LookAt(toObject.transform);
        transform.position = Vector3.Lerp(transform.position,toObject.transform.position, MoveSnake.SpeedSnake * Time.deltaTime);
    }
}
