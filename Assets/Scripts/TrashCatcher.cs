using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCatcher : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }
    }
