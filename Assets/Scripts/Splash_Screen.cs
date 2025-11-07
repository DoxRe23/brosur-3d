using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash_Screen : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Time());
    }

    IEnumerator Time()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel("Loading_Screen");
    }
}
