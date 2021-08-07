using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSnake : MonoBehaviour
{
    public Vector3 Cursor;
    public Transform Snake;
    public float SpeedToTap;

    

    float RotateAngle = 45f;
    void OnMouseDrag()
    {

        Cursor = Input.mousePosition;
        Cursor = Camera.main.ScreenToViewportPoint(Cursor);
       //Debug.Log((Cursor.x - 0.5f) * 6.8f);
       // Snake.position = new Vector3((Cursor.x-0.5f)*6.8f, Snake.position.y, Snake.position.z);
        Snake.position = Vector3.MoveTowards(Snake.position, new Vector3((Cursor.x - 0.5f) * 6.8f, Snake.position.y, Snake.position.z), SpeedToTap * Time.deltaTime);


        
        float rotateAroundY;
        Quaternion target;
        if ((Cursor.x - 0.5f ) * 6.8f  != Snake.transform.position.x) 
        {
            rotateAroundY = (Cursor.x - 0.5f) * RotateAngle;
            target = Quaternion.Euler(0, rotateAroundY, 0);
        }
        else 
        {
            target = Quaternion.Euler(0, 0, 0);
        }
        Snake.LookAt(new Vector3((Cursor.x - 0.5f) * 6.8f, Snake.position.y, Snake.position.z+1f));

        

    }
    void OnMouseUp()
    {
        Snake.LookAt(new Vector3(Snake.position.x, Snake.position.y, Snake.position.z + 1f));
    }


        void FixedUpdate()
    { 

       
    }





}



