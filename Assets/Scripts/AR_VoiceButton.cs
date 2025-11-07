using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AR_VoiceButton : MonoBehaviour
{
    public Text TextTargetName;
    public AudioSource VoicePanci;
    public AudioSource VoicePenggorengan;
    public AudioSource VoicePisau;
    public AudioSource VoiceTalenan;
    
    void Start()
    {      
    }

    void Update()
    {       
    }

    public void VoiceButtonClicked()
    { 
        VoicePanci.Stop();
        VoicePenggorengan.Stop();
        VoicePisau.Stop();
        VoiceTalenan.Stop();
        if (TextTargetName.text == "panci_masak") {
        VoicePanci.Play();
        }
        if (TextTargetName.text == "wajan_penggorengan") {
        VoicePenggorengan.Play();
        }
        if (TextTargetName.text == "pisau_dapur") {
        VoicePisau.Play();
        }
        if (TextTargetName.text == "talenan") {
        VoiceTalenan.Play();
        }
    }
}
