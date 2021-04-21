/*
 * George Tang
 * FacadeManager.cs
 * Assignment 11
 * calling functions to decrease and increase waldo the square
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class FacadeManager : MonoBehaviour
{
    public WaldoSize waldo;
    public WaldoJrSize waldoJr;
    public Text text;
    TextTracker textTracker;

    // Start is called before the first frame update
    void Start()
    {
        textTracker = new TextTracker(waldo, waldoJr);
        textTracker.TextUpdate(text);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sizeWaldoIncrease();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sizeWaldoDecrease();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

    public void sizeWaldoIncrease()
    {
        waldo.sizeIncrease();
        waldoJr.sizeIncrease();
        textTracker.TextUpdate(text);
    }

    public void sizeWaldoDecrease()
    {
        waldo.sizeDecrease();
        waldoJr.sizeDecrease();
        textTracker.TextUpdate(text);
    }
}
