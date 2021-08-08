using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SnakeCollision : MonoBehaviour
{
    

    public static int countCrystals = 0;

    public Text countCrystals_Text;
    void OnTriggerEnter(Collider collider)
    {
        

        if (collider.gameObject.name == "ChangeMaterialCheckPoint(Clone)")
        {
            
            Renderer render = GetComponent<Renderer>();
            render.material = collider.gameObject.GetComponent<MeshRenderer>().material;
        }

        if (collider.gameObject.name == "CrystalPrefab(Clone)")
        {
            countCrystals++;
            countCrystals_Text.text = "*: " + countCrystals.ToString();
            Destroy(collider.gameObject);
           
               
        }
        if (collider.gameObject.name == "MinePrefab(Clone)")
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Single);
        }
        //
    }
}
