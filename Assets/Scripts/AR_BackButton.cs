using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_BackButton : MonoBehaviour
{

    public AudioSource Audio;

void Start()
    {
    }

    void Update()
    {    
    }

    public void BacktoMenuButtonClicked()
    {
        Audio.Play();
        Application.LoadLevel("Main_Menu");
    }
}
