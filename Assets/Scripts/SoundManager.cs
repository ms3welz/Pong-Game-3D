using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SoundManager : MonoBehaviour
{
    public bool musicIsOn;
    public GameObject[] thisObj;

    [Header("Background Music")]
    [SerializeField] AudioClip[] bgmSounds;
    AudioSource myAudioSource;

    [Header("Button SFX")]
    [SerializeField] AudioClip buttonSounds;
    AudioSource myAudioButton;

    [Header("Game SFX")]
    [SerializeField] AudioClip goalSounds;
    [SerializeField] AudioClip winSounds;
    [SerializeField] AudioClip loseSounds;
    [SerializeField] AudioClip spawnSounds;
    [SerializeField] AudioClip poleSounds;
    [SerializeField] AudioClip playerSounds;
    AudioSource myAudioSFX;

    public void Awake()
    {
        musicIsOn = true;

        thisObj = GameObject.FindGameObjectsWithTag("SoundManager");

        if (thisObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }

    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        myAudioButton = GetComponent<AudioSource>();
        myAudioSFX = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (musicIsOn == true)
        {
            if (!myAudioSource.isPlaying)
            {
                Bgm();
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (EventSystem.current.currentSelectedGameObject != null)
                {
                    if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() != null)
                    {
                        ButtonSfx();
                    }
                }
            }
        }
    }

    public void Bgm()
    {
        AudioClip clip = bgmSounds[UnityEngine.Random.Range(0, bgmSounds.Length)];
        myAudioSource.PlayOneShot(clip, 0.75f);
    }

    public void ButtonSfx()
    {
        AudioClip buttonClip = buttonSounds;
        myAudioButton.PlayOneShot(buttonClip);
    }

    public void GoalSfx()
    {
        AudioClip goalClip = goalSounds;
        myAudioSFX.PlayOneShot(goalClip);
    }

    public void WinSfx()
    {
        AudioClip winClip = winSounds;
        myAudioSFX.PlayOneShot(winClip);
    }

    public void LoseSfx()
    {
        AudioClip loseClip = loseSounds;
        myAudioSFX.PlayOneShot(loseClip);
    }

    public void SpawnSFX()
    {
        AudioClip spawnClip = spawnSounds;
        myAudioSFX.PlayOneShot(spawnClip);
    }

    public void PoleSFX()
    {
        AudioClip poleClip = poleSounds;
        myAudioSFX.PlayOneShot(poleClip);
    }

    public void PlayerSFX()
    {
        AudioClip playerClip = playerSounds;
        myAudioSFX.PlayOneShot(playerClip);
    }
}
