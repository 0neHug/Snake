using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSnake : MonoBehaviour
{
    [SerializeField]
    public float Speed;
    public float cooldownFever = 5f;
    public static float SpeedSnake;
    public GameObject toObject;

    public GameObject Mouth;
    public GameObject FeverMouth;

    public Text countCrystals_Text;

    private BoxCollider snakeCollide;
    private void Start()
    {
        snakeCollide = GetComponent<BoxCollider>();
    }
    void FixedUpdate()
    {
        SpeedSnake = Speed;
        transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(0f,0f,1f), SpeedSnake * Time.deltaTime);
        if (SnakeCollision.countCrystals > 3 )

        {
            
           
            SpeedSnake *= 3;
            transform.position = Vector3.Lerp(new Vector3(0f, 0f, transform.position.z), new Vector3(0f, 0f, transform.position.z) + new Vector3(0f, 0f, 1f), SpeedSnake * Time.deltaTime);
            //transform.position = new Vector3(0f, 0f, transform.position.z);
            StartCoroutine(feverMode());
            
        }
        Debug.Log(SnakeCollision.countCrystals);
    }

    private IEnumerator feverMode()
    {
        snakeCollide.enabled = !snakeCollide.enabled;
        FeverMouth.SetActive(true);
        Mouth.SetActive(false);
        yield return new WaitForSeconds(cooldownFever);
        SnakeCollision.countCrystals = 0;
        countCrystals_Text.text = "*: " + SnakeCollision.countCrystals.ToString();
        SpeedSnake = 3f;
        FeverMouth.SetActive(false);
        Mouth.SetActive(true);
        snakeCollide.enabled = !snakeCollide.enabled;

    }
    }
