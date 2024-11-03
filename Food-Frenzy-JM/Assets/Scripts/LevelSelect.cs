using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        for(int i = 0; i < buttons.Length; i++) // loops till i is less than button length
        {
            int score = PlayerPrefs.GetInt(buttons[i].playerPrefKey, 0);// sets the interger score to the player pref key

            for (int starIndex = 1; starIndex <= 3; starIndex++) //will loop till star index is less or equal to 3
            {
                Transform star = buttons[i].gameObject.transform.Find("Star" + starIndex);//will identify the star with the star index number 
                if (starIndex <= score)// if the star index is less or equal to the score
                {
                    star.gameObject.SetActive(true);// makes the star gameobject to true
                }
                else//otherwise
                {
                    star.gameObject.SetActive(false);// makes the star gameobject to false
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress (string levelName)// makes a function for the string of level name so level01 would be scene1 
    {
        SceneManager.LoadScene(levelName);// loads the scene name
    }
    [System.Serializable]
    public struct ButtonPlayerPrefs//creates your own data type. for this one for button player prefs
    {
        public GameObject gameObject;
        public string playerPrefKey;
    }

    public ButtonPlayerPrefs[] buttons;// makes a array for the button player prefs and for buttons
}
