using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public float highscore;
    public Text HighScoreTxt;

    public void starGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Start()
    {
        highscore = PlayerPrefs.GetFloat("Highscore");
    }

    public void Update()
    {
        HighScoreTxt.text = ((int)highscore).ToString();
    }
}
