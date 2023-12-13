using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//HCS
public class gameMenu : MonoBehaviour
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