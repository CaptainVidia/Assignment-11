/*
 * George Tang
 * TextTracker.cs
 * Assignment 11
 * shows the text and information of how much size has been increased and decreased
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTracker : MonoBehaviour
{
    public WaldoSize waldo;
    public WaldoJrSize waldoJr;

    public TextTracker(WaldoSize waldo, WaldoJrSize waldoJr)
    {
        this.waldo = waldo;
        this.waldoJr = waldoJr;
    }

    public void TextUpdate(Text text)
    {
        text.text = "Waldo size is: " + waldo.size + "\nWaldoJr size is: " + waldoJr.size;
        
    }
}
