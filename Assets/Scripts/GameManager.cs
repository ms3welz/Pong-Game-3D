using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public BallManager ballManager;
    public List<GoalManager> goalManagerList;

    public GameObject panelGameOver;
    public Text namePlayertext;

    public bool gameIsPaused;
    public GameObject panelPauseMenu;

    [Header("Sound Manager")]
    [SerializeField] private SoundManager soundManager;
    private bool endGame = false;
    private bool playerLose = true;

    void Start()
    {
        Time.timeScale = 1;

        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {

        for (int i = 0; i < goalManagerList.Count; i++)
        {
            if (goalManagerList[i].golPoin >= 15 && playerLose == true)
            {
                goalManagerList.Remove(goalManagerList[i]);
            }

            if (goalManagerList.Count == 1)
            {
                goalManagerList[0].WinningCeremony();
            }

            if (goalManagerList.Count == 1 && endGame == false)
            {
                PlayerCountOne();
            } 
        }
    }

    public void PlayerCountOne()
    {
        ballManager.gameOver = true;
        
        Invoke("GameOver", 4);
        Debug.Log("gameOver");
        StartCoroutine(WinSound());

        endGame = true;
    }

    public IEnumerator WinSound()
    {
        yield return new WaitForSeconds(0.4f);
        soundManager.WinSfx();
    }

    public void GameOver()
    {
        panelGameOver.SetActive(true);
        namePlayertext.text = goalManagerList[0].playerName.ToString()+ " Win";
    }

    public void PauseButton()
    {
        gameIsPaused = !gameIsPaused;
        PausePanel();
    }

    public void PausePanel()
    {
        if (gameIsPaused)
        {
            panelPauseMenu.SetActive(true);
            Time.timeScale = 0f;
            AudioListener.pause = true;
        }
        else
        {
            panelPauseMenu.SetActive(false);
            Time.timeScale = 1;
            AudioListener.pause = false;
        }
    }
}
