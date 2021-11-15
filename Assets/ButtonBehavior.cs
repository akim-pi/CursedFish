﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    int n;
    public Text myText;
    public void OnButtonPress()
    {
        n++;
        myText.text = "Button clicked " + n + " times.";
    }
}
