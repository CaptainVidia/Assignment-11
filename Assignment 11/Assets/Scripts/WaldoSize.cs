/*
 * George Tang
 * WaldoSize.cs
 * Assignment 11
 * Increases and decreases the size of Waldo the square
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaldoSize : MonoBehaviour
{
    public float size = 3;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.localScale = new Vector3(size, size, size);
    }

    public void sizeIncrease()
    {
        if (size < 10)
        {
            size++;
            gameObject.transform.localScale = new Vector3(size, size, size);
        }
    }

    public void sizeDecrease()
    {
        if (size > 5)
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
