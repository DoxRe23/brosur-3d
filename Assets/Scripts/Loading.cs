using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Transform LoadingBar;
    
    [SerializeField]
    private float CurrentValue;
    [SerializeField]
    private float LoadingSpeedValue;

    void Update()
    {
        if (CurrentValue < 100) 
        {
            CurrentValue += LoadingSpeedValue * Time.deltaTime;
            Debug.Log ((int)CurrentValue);
        }
        else
        {
            Application.LoadLevel ("Main_Menu");
        }
        LoadingBar.GetComponent<Image> ().fillAmount = CurrentValue / 100;
    }
}
