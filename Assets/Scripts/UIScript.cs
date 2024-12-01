using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject UIPanel,InteractPop,pauseMenu;
    public Scrollbar Scrollbar;

    public Button narrate;
    public bool startTimer;
    public float narrateTimer,narTimerTarget;

    public string para1, para2,para3,para4,para5,para6;

    public AudioSource audios;
    public AudioClip nar1, nar2, nar3, nar4, nar5, nar6;

    public GameObject player;
    void Start()
    {
        audios.clip = nar1;
        InteractPop.SetActive(false);
        Screen.SetResolution(1920, 1080, true);
    }

    // Update is called once per frame
    void Update()
    {
        pauseMenu.SetActive(player.GetComponent<PlayerMovement>().pauseMenu);
        if(player.GetComponent<PlayerMovement>().inspect == false && player.GetComponent<PlayerMovement>().canInspect == true)
        {
            InteractPop.SetActive(true);
        }
        else
        {
            InteractPop.SetActive(false);
        }
        if(startTimer)
        {
            narrateTimer += Time.deltaTime;
        }
        if (narrateTimer > narTimerTarget)
        {
            narrate.GetComponent<Button>().enabled = true;
            narrateTimer = 0;
            startTimer = false;
        }
    }
    public void EnablePanel()
    {
       UIPanel.SetActive(true);
    }
    public void ButtonClose()
    {
        Scrollbar.value = 1;
        narrate.GetComponent<Button>().enabled = true;
        UIPanel.SetActive(false);
        audios.Stop();
        narrateTimer = 0;
        startTimer = false;
    }
    public void ButtonNarrate()
    {
        startTimer = true;
        narrate.GetComponent<Button>().enabled = false;
        audios.Play();
    }

    public void ButtonResume()
    {
        player.GetComponent<PlayerMovement>().pauseMenu = false;
    }
    public void ButtonQuit()
    {
        Application.Quit();
    }
}
