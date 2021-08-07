using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointChanged : MonoBehaviour
{
    public Material[] _allMaterials;
    SnakeCollision Snake;
    public int enemyMaterial;
    public int friendMaterial;


    void Start()
    {

        Snake = GameObject.FindObjectOfType<SnakeCollision>();

        Renderer render = GetComponent<Renderer>();
        render.material = null;
        friendMaterial = Random.Range(0, 5);
        render.material = _allMaterials[friendMaterial];
        while (render.material == Snake.GetComponent<MeshRenderer>().material)
        {
            friendMaterial = Random.Range(0, 5);
            render.material = _allMaterials[friendMaterial];
        }

        enemyMaterial = Random.Range(0, 5);
        while (enemyMaterial == friendMaterial)
        {
            enemyMaterial = Random.Range(0, 5);
        }
    }


}
