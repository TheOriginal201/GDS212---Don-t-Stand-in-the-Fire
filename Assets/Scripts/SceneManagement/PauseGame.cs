using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseWindow;
    //public GameObject levelLoader;


    public void PauseWindow()
    {
        //levelLoader.SetActive(true);
        
        //pause game time
        //open pause menu
        Time.timeScale = 0;
        pauseWindow.SetActive(true);
    }

    public void UnPause()
    {
        //close pause menu
        //start game time
        pauseWindow.SetActive(false);
        Time.timeScale = 1;
    }



}
