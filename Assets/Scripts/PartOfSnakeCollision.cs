using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartOfSnakeCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {


        if (collider.gameObject.name == "ChangeMaterialCheckPoint(Clone)")
        {

            Renderer render = GetComponent<Renderer>();
            render.material = collider.gameObject.GetComponent<MeshRenderer>().material;
        }
    }

}
