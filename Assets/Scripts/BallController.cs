using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    public GameObject ballManager;

    public List<GameObject> goalManagerList;

    private float randomDiff;
    [SerializeField] private Vector3 localPosBall;

    [Header("Sound Manager")]
    [SerializeField] private SoundManager soundManager;

    void Start()
    {
        randomDiff = Random.Range(-0.5f, 0.5f);

        ball.GetComponent<Rigidbody>().AddForce((transform.forward+(transform.right*randomDiff))*300);

        foreach(GameObject goalManagerTemp in GameObject.FindGameObjectsWithTag("Goal"))
        {
            goalManagerList.Add(goalManagerTemp);
        }

        for (int i = 0; i < goalManagerList.Count; i++)
        {
            goalManagerList[i].GetComponent<GoalManager>();
        }

        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        soundManager.SpawnSFX();
    }

    void Update()
    {
        localPosBall = new Vector3(transform.localPosition.x,0, transform.localPosition.z);

        if(ballManager == null)
        {
            ballManager = GameObject.FindWithTag("BallManager");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pole")
        {
            Debug.Log("Pole");
 
            ball.GetComponent<Rigidbody>().AddForce(localPosBall*-2, ForceMode.VelocityChange);

            ball.GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(ball.GetComponent<Rigidbody>().velocity, 4);
        }

        if (collision.gameObject.tag == "Player")
        {
            soundManager.PlayerSFX();
            Debug.Log("Player");
        }

        if (collision.gameObject.tag == "Arena")
        {
            if(ball.transform.localPosition.y >= 0.5f)
            {
                ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
            }
            Debug.Log("Arena");
        }

        if (collision.gameObject.tag == "Goal")
        {
            for (int i = 0; i < goalManagerList.Count; i++)
            {
                if(goalManagerList[i].GetComponent<GoalManager>().golPoin >= 15)
                {
                    ball.GetComponent<Rigidbody>().AddForce(localPosBall * -1.5f, ForceMode.VelocityChange);
                }
            }
        }
    }

    public void OnTriggerEnter(Collider ball)
    {
        if(ball.gameObject.tag == "Goal")
        {
            Debug.Log("Gol");
            if (ballManager != null)
            {
                ballManager.GetComponent<BallManager>().RemoveBall(gameObject);
            }
        }
    }
}
