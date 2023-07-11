using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [Header("Music Button")]
    public GameObject musicButtonOn;
    public GameObject musicButtonOff;

    public bool musicIsOn;
    public bool musicIsOff;

    void Update()
    {
        IconMusic();
    }

    public void MusicButtonON()
    {
        musicIsOn = false;
        AudioListener.pause = true;
    }

    public void MusicButtonOff()
    {
        musicIsOn = true;
        AudioListener.pause = false;

    }

    public void IconMusic()
    {
        if (musicIsOn == true)
        {
            musicButtonOn.gameObject.SetActive(true);
            AudioListener.pause = false;
        }
        else
            musicButtonOn.gameObject.SetActive(false);

        if (musicIsOn == false)
        {
            musicButtonOff.gameObject.SetActive(true);
            AudioListener.pause = true;
        }
        else
            musicButtonOff.gameObject.SetActive(false);
    }
}
