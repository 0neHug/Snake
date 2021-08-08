using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSnake : MonoBehaviour
{


    [SerializeField]
    public float Speed;
    public float feverCooldown = 5f;
    public static float SpeedSnake;

    
    public GameObject Mouth;

    
    public GameObject fevetMouth;



    private void Start()
    {
        CrystalsCollision.countCrystals = 0;
    }

   
        
        void FixedUpdate()
        {
            SpeedSnake = Speed;
            transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(0f, 0f, 1f), SpeedSnake * Time.deltaTime);
             if (CrystalsCollision.countCrystals > 3)
             {
                StartCoroutine(feverMode());
                
             }


    }

    
    private IEnumerator feverMode()
    {
        fevetMouth.SetActive(true);
        

        Mouth.SetActive(false);

        SpeedSnake*=3;
        transform.position = new Vector3(0f, 0f, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(0f, 0f, 1f), SpeedSnake  * Time.deltaTime);
        Quaternion target = Quaternion.Euler(transform.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, 1);
        yield return new WaitForSeconds(feverCooldown);
        CrystalsCollision.countCrystals = 0;

        fevetMouth.SetActive(false);
        

        Mouth.SetActive(true);
        
        
    }

    }
