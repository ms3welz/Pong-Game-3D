using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public int spawnIntervalBall;
    private float timer;

    public bool playGame;
    public bool gameOver;

    [Header("Spawn List")]
    public GameObject prefabBall;
    public List<GameObject> spawnArea;
    public Transform spawnParent;

    [Header("Ball List")]
    public List<GameObject> ballList;
    public int maxBall;

    public void PlayGame()
    {
        playGame = true;
        gameOver = false;

        ballList = new List<GameObject>();
        GenerateBall();
        timer = 0;
        
    }

    void Update()
    {
        if(playGame == true)
        {
            if (gameOver == false)
            {
                timer += Time.deltaTime;
                if (timer > spawnIntervalBall)
                {
                    GenerateBall();
                    timer -= spawnIntervalBall;
                }
            }
            if (gameOver == true)
            {
                RemoveAllBall();
            }
        }
    }

    public void GenerateBall()
    {
        if(ballList.Count >= maxBall)
        {
            return;
        }

       int randomSpawnArea = Random.Range(0, spawnArea.Count);
       GameObject ball = Instantiate(prefabBall, spawnArea[randomSpawnArea].transform.position, spawnArea[randomSpawnArea].transform.localRotation, spawnParent);
       ballList.Add(ball);
    }

    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Debug.Log("remove");
        Destroy(ball);
    }

    public void RemoveAllBall()
    {
        while (ballList.Count >0)
        {
            RemoveBall(ballList[0]);
        }
    }
}
