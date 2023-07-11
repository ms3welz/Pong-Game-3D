using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Player { Player_1, Player_2, Player_3, Player_4 }

public class GoalManager : MonoBehaviour
{
    public Player myPlayer;
    public string playerName;
    public Text uiText;
    public int golPoin;
    [Header("Sound Manager")]
    [SerializeField] private SoundManager soundManager;

    [Header("Paddle Player")]
    [SerializeField] private GameObject padlle_Player;
    [SerializeField] private GameObject gameManager;

    [Header("Wall Active")]
    private Vector3 wallActive;
    private float wallScaleY = 5f;
    private Vector3 velocity = Vector3.zero;
    private float smoothTime = 0.5f;

    [Header("Winning Active")]
    private Vector3 winningActive;
    private Vector3 winningActiveZ;
    private Vector3 winningActiveX;

    void Start()
    {
        playerName = myPlayer.ToString();

        wallActive = new Vector3(transform.localScale.x,wallScaleY, transform.localScale.z);

        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {
        uiText.text = golPoin.ToString();

        winningActive = padlle_Player.transform.position;
        winningActiveZ = new Vector3(winningActive.x, winningActive.y, winningActive.z / 2); // Winning For Paddle 1 & 2
        winningActiveX = new Vector3(winningActive.x / 2, winningActive.y, winningActive.z); // Winning For Paddle 3 & 4

        PlayerGoalPoin();
    }

    public void PlayerGoalPoin()
    {
        if (myPlayer == Player.Player_1 && golPoin >= 15)
        {
            this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            this.gameObject.transform.localScale = Vector3.SmoothDamp(transform.localScale, wallActive, ref velocity, smoothTime);
            padlle_Player.SetActive(false);
        }
        if (myPlayer == Player.Player_2 && golPoin >= 15)
        {
            this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            this.gameObject.transform.localScale = Vector3.SmoothDamp(transform.localScale, wallActive, ref velocity, smoothTime);
            padlle_Player.SetActive(false);
        }
        if (myPlayer == Player.Player_3 && golPoin >= 15)
        {
            this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            this.gameObject.transform.localScale = Vector3.SmoothDamp(transform.localScale, wallActive, ref velocity, smoothTime);
            padlle_Player.SetActive(false);
        }
        if (myPlayer == Player.Player_4 && golPoin >= 15)
        {
            this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            this.gameObject.transform.localScale = Vector3.SmoothDamp(transform.localScale, wallActive, ref velocity, smoothTime);
            padlle_Player.SetActive(false);
        }
    }

    public void PlayerGoal(Player myPlayer)
    {
        if(myPlayer == Player.Player_1)
        {
            Debug.Log("Player 1 Gol");
            golPoin += 1;
        }
        if (myPlayer == Player.Player_2)
        {
            Debug.Log("Player 2 Gol");
            golPoin += 1;
        }
        if (myPlayer == Player.Player_3)
        {
            Debug.Log("Player 3 Gol");
            golPoin += 1;
        }
        if (myPlayer == Player.Player_4)
        {
            Debug.Log("Player 4 Gol");
            golPoin += 1;
        }
    }

    public void WinningCeremony()
    {
        if(padlle_Player.transform.localRotation.y == 0)
        {
            padlle_Player.transform.localPosition = Vector3.SmoothDamp(winningActive,winningActiveZ , ref velocity, smoothTime);
            Debug.Log("Winning Ceremony 1 2");
        }
        else
        {
            padlle_Player.transform.localPosition = Vector3.SmoothDamp(winningActive, winningActiveX, ref velocity, smoothTime);
            Debug.Log("Winning Ceremony 3 4");
        }
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Ball")
        {
            soundManager.GoalSfx();
            PlayerGoal(myPlayer);
        }

        if (col.gameObject.tag == "Ball" && golPoin >= 15)
        {
            StartCoroutine(LoseSound());
        }
    }

    public IEnumerator LoseSound()
    {
        yield return new WaitForSeconds(0.2f);
        soundManager.LoseSfx();
    }
}
