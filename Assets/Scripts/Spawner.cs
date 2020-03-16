using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    public bool spawnActive = false;
    [SerializeField] List<GameObject> spawnList;
    [SerializeField] List<GameObject> bubbleList;

    private int randomBubble;
    private int randomSpawn;
    private float bubblePicker;
    private float gameTimer;
    private float speed;
    private GameObject bubbleClon;

    void Start()
    {
        //StartCoroutine(spawnRate());
    }

    
    void Update()
    {

        if (spawnActive)
        {
            gameTimer = gameTimer + Time.deltaTime;

            if (gameTimer >= 0 && gameTimer < 20)
            {
                speed = 0.3f;
            }
            else if (gameTimer >= 20 && gameTimer < 40)
            {
                speed = 0.6f;
            }
            else if (gameTimer >= 40 && gameTimer < 50)
            {
                speed = 1f;
            }
            else if (gameTimer >= 50 && gameTimer < 60)
            {
                speed = 2f;
            }
            else if (gameTimer >= 60)
            {
                speed = 2.5f;
            }
        }
        
    }

    private void SpawnerMethod()
    {
        System.Random random = new System.Random();
        int randomSpawn = random.Next(0, 5);

        System.Random random2 = new System.Random();
        float bubblePicker = random2.Next(0, 100);        

        if (bubblePicker >= 0 && bubblePicker <= 15)
        {
            bubbleClon = Instantiate(bubbleList[5], spawnList[randomSpawn].transform.position, Quaternion.identity);
            bubbleClon.GetComponent<Love>().speed = speed;
        }
        else if (bubblePicker >= 15.1f && bubblePicker <= 30)
        {
            bubbleClon = Instantiate(bubbleList[3], spawnList[randomSpawn].transform.position, Quaternion.identity);
            bubbleClon.GetComponent<Intelligence>().speed = speed;
        }
        else if (bubblePicker >= 30.1f && bubblePicker <= 45)
        {
            bubbleClon = Instantiate(bubbleList[2], spawnList[randomSpawn].transform.position, Quaternion.identity);
            bubbleClon.GetComponent<Flirt>().speed = speed;
        }
        else if (bubblePicker >= 45.1f && bubblePicker <= 65)
        {
            bubbleClon = Instantiate(bubbleList[0], spawnList[randomSpawn].transform.position, Quaternion.identity);
            bubbleClon.GetComponent<Affection>().speed = speed;
        }
        else if (bubblePicker >= 65.1f && bubblePicker <= 95)
        {
            bubbleClon = Instantiate(bubbleList[1], spawnList[randomSpawn].transform.position, Quaternion.identity);
            bubbleClon.GetComponent<Boorish>().speed = speed;
        }
        else if (bubblePicker >= 95.1f && bubblePicker <= 100)
        {
            bubbleClon = Instantiate(bubbleList[4], spawnList[randomSpawn].transform.position, Quaternion.identity);
            bubbleClon.GetComponent<Intimacy>().speed = speed;
        }
    }

    IEnumerator spawnRate()
    {
       
        while (true)
        {
            if (gameTimer >= 0 && gameTimer <20)
            {
                yield return new WaitForSeconds(3f);
            }
            else if (gameTimer >= 20 && gameTimer < 40)
            {
                yield return new WaitForSeconds(2f);
            }
            else if (gameTimer >= 40 && gameTimer < 50)
            {
                yield return new WaitForSeconds(0.8f);
            }            
            else if (gameTimer >= 50 && gameTimer < 60)
            {
                yield return new WaitForSeconds(0.3f);
            }
            else if (gameTimer >= 60)
            {
                yield return new WaitForSeconds(0.2f);
            }

            SpawnerMethod();
        }
    }

    public void SpawActiveTrue()
    {
        spawnActive = true;
    }

    public void CoorutineActivation()
    {
        StartCoroutine(spawnRate());
    }

}

