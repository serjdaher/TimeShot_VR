using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float currentTime;
    public bool countDown;
    [SerializeField] GameObject gameover;
    [SerializeField] GameObject clear;

    public bool start = false;

    void Start()
    {
        gameover.SetActive(false);
        clear.SetActive(false);
    }

    void Update()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
        if (start == true)
        {
            currentTime = currentTime -= Time.deltaTime;
            timeText.text = currentTime.ToString();
            
        }

        if(targets.Length == 0)
        {
            start = false;
            currentTime = currentTime + 0;
            timeText.text = currentTime.ToString();
            clear.SetActive(true);
            StartCoroutine(ReloadScene());
        }

        if (currentTime <= 0.0f)
        {
            start = false;
            gameover.SetActive(true);
            currentTime = 0.0f;
            timeText.text = currentTime.ToString();
            StartCoroutine(ReloadScene());
        }
    }

    IEnumerator ReloadScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Shooter");
    }

    public void StartedShooting()
    {
        start = true;
    }
}