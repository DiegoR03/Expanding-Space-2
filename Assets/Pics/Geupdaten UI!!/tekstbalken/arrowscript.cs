﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrowscript : MonoBehaviour
{
    public GameObject activetext;
    public GameObject nextactivetext;
    
    public GameObject turnarrowon;
    // Start is called before the first frame update
    void Start()
    {
        if(activetext.activeSelf == true)
        {
            turnarrowon.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(nextactivetext.activeSelf == true)
        {
            turnarrowon.SetActive(false);
        }
    }
}
