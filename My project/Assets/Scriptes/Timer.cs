using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private float sec = 60;

    private void FixedUpdate()
    {
        if (sec > 0)
        {
            sec -= Time.deltaTime;
            timerText.text = Mathf.Round(sec).ToString();
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
