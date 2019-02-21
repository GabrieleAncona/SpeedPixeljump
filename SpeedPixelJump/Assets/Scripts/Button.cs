using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
 

    public void Esc()
    {
        Application.Quit();

    }

    public void MenùPrincipale()
    {

        SceneManager.LoadScene("Menù");
    }

    public void GameOver()
    {

        SceneManager.LoadScene("GameOver");
    }

    public void Play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

   public void Opzioni()
    {
        SceneManager.LoadScene("Opzioni");
    }

}