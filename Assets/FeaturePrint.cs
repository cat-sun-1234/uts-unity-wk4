﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeaturePrint : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(this.gameObject.name + ": " + i);
    }
}
