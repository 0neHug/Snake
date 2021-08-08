using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject _minePrefab;
    public GameObject _crystalPrefab;

    public float spawnRangeMinesAndCrystals = 2.2f;
    public float spawnCooldownMinesAndCrystals = 1.0f;



    public GameObject _groupHumanPrefab;

    public float spawnCooldownHumans = 1.5f;
   

    public GameObject _checkPoint;

    





    public float waitPart = 2.0f;
    bool isLevel=false;
    void Start()
    {
        StartCoroutine(spawnCycle());
        StartCoroutine(LevelLife());


    }

    private IEnumerator spawnCycle()
    {
        
        for (int i = 0; i <= 5; i++)
        {
            Instantiate(_groupHumanPrefab, transform.position, transform.rotation);

            yield return new WaitForSeconds(spawnCooldownHumans);
        }

        yield return new WaitForSeconds(waitPart);
        
        for (int i = 0; i<3;i++) 
        {
            Instantiate(_minePrefab, new Vector3(transform.position.x + spawnRangeMinesAndCrystals * Random.Range(-1, 2), _minePrefab.transform.position.y, transform.position.z), Quaternion.identity);
            Instantiate(_crystalPrefab, new Vector3(transform.position.x + spawnRangeMinesAndCrystals * -1, _crystalPrefab.transform.position.y, transform.position.z), Quaternion.identity);
            Instantiate(_crystalPrefab, new Vector3(transform.position.x + spawnRangeMinesAndCrystals * 0, _crystalPrefab.transform.position.y, transform.position.z), Quaternion.identity);
            Instantiate(_crystalPrefab, new Vector3(transform.position.x + spawnRangeMinesAndCrystals * 1, _crystalPrefab.transform.position.y, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(spawnCooldownMinesAndCrystals);
        }

       

        yield return new WaitForSeconds(waitPart);
        
        Instantiate(_checkPoint, new Vector3(transform.position.x , _checkPoint.transform.position.y, transform.position.z), Quaternion.identity);

        

        yield return new WaitForSeconds(waitPart);
        newSpawnCycle();
    }

   
    void newSpawnCycle()
    {
        if (isLevel == true)
        StartCoroutine(spawnCycle());
    }
    private IEnumerator LevelLife()
    {
        isLevel = true;
        yield return new WaitForSeconds(40);
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

}
