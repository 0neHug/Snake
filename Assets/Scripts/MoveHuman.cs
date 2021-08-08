using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHuman : MonoBehaviour
{
    CheckPointChanged _checkPoint;
    public Material[] _allMaterials;
    bool isEated;
    Transform pointToEat;
    float speedEat = 3f;
    void Start()
    {
        Renderer render = GetComponent<Renderer>();
      
        _checkPoint = GameObject.FindObjectOfType<CheckPointChanged>();
        if (gameObject.name == "HumanPrefabFriend(Clone)")
        {
            
            
            render.material = _allMaterials[_checkPoint.friendMaterial];
        }
        if (gameObject.name == "HumanPrefabEnemy(Clone)")
        {


            render.material = _allMaterials[_checkPoint.enemyMaterial];
        }


    }


    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "Mouth")
        {

            
            isEated = true;
            pointToEat = collider.transform;

            if (isEated) transform.position = Vector3.MoveTowards(transform.position, pointToEat.position, speedEat * Time.deltaTime);

        }
        
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Mouth")
        {
            isEated = false;
        }
    }
 
}
