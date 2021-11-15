using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellSound : MonoBehaviour
{

        AudioSource mySource;
        // Use this for initialization
        void Start()
        {
            mySource = GetComponent<AudioSource>();
        }

    void OnMouseDown()
    {
        Debug.Log("Clicked!");
        mySource.Play();
    }
}
