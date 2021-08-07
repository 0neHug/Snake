using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGroupHuman : MonoBehaviour
{
    public GameObject _humansPrefabFriend;
    public GameObject _humansPrefabEnemy;

    public Transform _spawnLeft;
    public Transform _spawnRight;

    public int spawnEnyHumans = 5;
    public float spawnRangeHumans = 1.8f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0,180 * Random.Range(0,2), 0);
        spawnEnyHumans = Random.Range(1,6);
        for (int j = 0; j <= spawnEnyHumans; j++)
        {
            Instantiate(_humansPrefabFriend,transform.position + new Vector3(_spawnLeft.position.x + Random.Range(-0.4f, 1.4f), 0f, Random.Range(-0.4f, 1.4f)), Quaternion.identity);


            

        }
        spawnEnyHumans = Random.Range(1, 6);
        for (int j = 0; j <= spawnEnyHumans; j++)
        {
            


            Instantiate(_humansPrefabEnemy, transform.position + new Vector3(_spawnRight.position.x + Random.Range(-0.4f, 1.4f), 0f, Random.Range(-0.4f, 1.4f)), Quaternion.identity);

        }
    }
}
