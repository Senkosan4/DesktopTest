﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadedStart : MonoBehaviour
{
    public AudioSource crashSound;
    public AudioSource starshipSound;

    public GameObject lightObj;

    public GameObject hintUI;

    public string shakeAnimName;

    public float delay;
    public static bool isStartLeverActive = false;

    void Start()
    {
        starshipSound.Play();
        lightObj.GetComponent<Light>().enabled = true;
        StartCoroutine(WaitAndDo());

        hintUI.SetActive(false);
    }

    IEnumerator WaitAndDo()
    {
        yield return new WaitForSeconds(delay);

        starshipSound.Stop();
        crashSound.Play();

        lightObj.GetComponent<Light>().enabled = false;

        isStartLeverActive = true;

        yield return new WaitForSeconds(2);

        hintUI.SetActive(true);
    }
}