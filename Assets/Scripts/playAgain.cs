using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playAgain : MonoBehaviour
{
    public GameObject gameOverPanel;
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);        }
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
