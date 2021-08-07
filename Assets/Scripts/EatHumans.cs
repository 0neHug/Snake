using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class EatHumans : MonoBehaviour
{
    int countDeathHuman = 0;

    public Text countDeathHuman_Text;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "HumanPrefabFriend(Clone)" )
        {
            countDeathHuman++;
            countDeathHuman_Text.text = "0.0: " + countDeathHuman.ToString();
            Destroy(collider.gameObject);
        }

        if ( collider.gameObject.name == "HumanPrefabEnemy(Clone)")
        {
            Destroy(collider.gameObject);
            SceneManager.LoadScene("Main", LoadSceneMode.Single);
        }
    }
}
