using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeverEatObject : MonoBehaviour
{
    bool isEated;
    Transform pointToEat;
    float speedEat = 10f;
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "FeverMouth")
        {


            isEated = true;
            pointToEat = collider.transform;

            if (isEated) transform.position = Vector3.MoveTowards(transform.position, pointToEat.position, speedEat * Time.deltaTime);

        }

    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "FeverMouth")
        {
            isEated = false;
        }
    }
}
