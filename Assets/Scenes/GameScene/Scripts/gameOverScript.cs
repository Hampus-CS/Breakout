using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverScript : MonoBehaviour
{
    
    public void Restart()
    {

        SceneManager.LoadScene("GameScene");

    }

    public void MainMenu()
    {

        SceneManager.LoadScene("MainMenu");

    }

}