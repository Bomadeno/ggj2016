﻿using UnityEngine;
using System.Collections;

public class BackExit : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
