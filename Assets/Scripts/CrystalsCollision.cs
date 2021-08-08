using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CrystalsCollision : MonoBehaviour
{
    int countCrystals = 0;

    public Text countCrystals_Text;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "SnakeHead")
        {
            countCrystals++;
            countCrystals_Text.text = "*: " + countCrystals.ToString();
            Destroy(collider.gameObject);
        }
    }

    }
