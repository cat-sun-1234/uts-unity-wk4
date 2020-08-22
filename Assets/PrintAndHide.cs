using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 0;
    int blueDisable;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        blueDisable = UnityEngine.Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if (this.gameObject.tag == "Red" && i == 100)
        {
            this.gameObject.SetActive(false);
        }
        if (this.gameObject.tag == "Blue" && i == blueDisable)
        {
            rend.enabled = false;
        }
        Debug.Log(this.gameObject.name + ": " + i);
    }
}
