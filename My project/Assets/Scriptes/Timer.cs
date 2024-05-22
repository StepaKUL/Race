using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public float sec = 60;
    [SerializeField] float minSlip = 0.55f;
    CarController CarController;

    private void Awake()
    {
        CarController = GetComponent<CarController>();
    }
    private void FixedUpdate()
    {
        if (CarController.CurrentMaxSlip > minSlip)
        {
            sec += Time.deltaTime;
            timerText.text = Mathf.Round(sec).ToString();
        }
        else if (sec > 0)
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
