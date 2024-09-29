using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// creates a scene management 

public class MainMenu : MonoBehaviour
{
    public void LevelChange(string level)// in levelchange
    {
        SceneManager.LoadScene(level);// loads level 1 
        PlayerPrefs.DeleteKey("LIVES_LEFT");// and keesp track of lives left
    }
}
