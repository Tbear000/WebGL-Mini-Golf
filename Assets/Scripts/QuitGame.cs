﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
       public void Quit () {
        Debug.Log("Game is exiting");
        Application.Quit ();
        //Just to make sure its working
    }
}
