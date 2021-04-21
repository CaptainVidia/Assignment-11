/*
 * George Tang
 * WaldoSize.cs
 * Assignment 11
 * Increases and decreases the size of Waldo Jr the square
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaldoJrSize : MonoBehaviour
{
    public float size = 1;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.localScale = new Vector3(size, size, size);
    }

    public void sizeIncrease()
    {
        if (size < 5)
        {
            size++;
            gameObject.transform.localScale = new Vector3(size, size, size);
        }
    }

    public void sizeDecrease()
    {
        if (size > 1)
        {
            size--;
            gameObject.transform.localScale = new Vector3(size, size, size);
        }

    }
    //// Update is called once per frame
    //void Update()
    //{

    //}
}
