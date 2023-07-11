using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownText;
    public GameObject countdownPanel;
    public BallManager ballManager;

    public void Awake()
    {
        countdownPanel.gameObject.SetActive(true);
    }
    void Start()
    {
        StartCoroutine(CountdownToPlay());
    }

    public IEnumerator CountdownToPlay()
    {
        while(countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownText.text = "GO!";
        
        yield return new WaitForSeconds(1f);
        ballManager.PlayGame();
        countdownPanel.gameObject.SetActive(false);
    }
}
