using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject HowtoPanel;
    public GameObject CreditsPanel;
    public AudioSource Audio;

    void Start()
    {
        MenuPanel.SetActive(true);
        HowtoPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    void Update()
    {
        
    }

    public void PlayButtonClicked()
    {
        Audio.Play();
        Application.LoadLevel("AR_Camera");
    }
   
    public void HowtoButtonClicked()
    {
        Audio.Play();
        MenuPanel.SetActive(false);
        HowtoPanel.SetActive(true);
        CreditsPanel.SetActive(false);
    }

    public void CreditsButtonClicked()
    {
        Audio.Play();
        MenuPanel.SetActive(false);
        HowtoPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }

    public void BackButtonClicked()
    {
        Audio.Play();
        MenuPanel.SetActive(true);
        HowtoPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    public void BacktoMenuButtonClicked()
    {
        Audio.Play();
        Application.LoadLevel("Main_Menu");
        MenuPanel.SetActive(true);
        HowtoPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    public void QuitButtonClicked()
    {
        Audio.Play();
        Application.Quit();
    }

}
