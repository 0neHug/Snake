using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform snakeHead;

    private Vector3 _cameraOffset;
   


    void Start()
    {



        _cameraOffset = transform.position - snakeHead.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Debug.Log(colorVar);


        transform.position = new Vector3(transform.position.x, transform.position.y, _cameraOffset.z + snakeHead.position.z);


    }
}
