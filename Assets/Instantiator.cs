﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Instantiate()
    {
        while (counter < 3)
        {
            Instantiate(objectToClone);
            counter++;
        }

        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
