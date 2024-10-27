using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
    public Level level;
    public TMP_Text remainingText;
    public TMP_Text remainingSubtext;
    public TMP_Text targetText;
    public TMP_Text targetSubtext;
    public TMP_Text scoreText;

    public Image[] stars;

    private int starIndex;
    private bool isGameOver;
    // Start is called before the first frame update

    //star0 star1 star2
    private void Start()
    {
        UpdateStars();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateStars()// update star function
    {
        for (int i = 0; i < stars.Length; i++)// sets i to 0 and makes sure it loops and that i is less than star length
        {
            if ( i == starIndex)// checks if i is equal to star Index
            {
                stars[i].enabled = true;// sets the star number enabled
            }
            else//otherwise
            {
                stars[i].enabled = false;// will not show the star
            }
        }
    }
    public void SetScore(int score)// makes a public void for set score with integer score
    {
        scoreText.text = score.ToString();// setszs the score text integer to a string ""

        int visibleStar = 0;// sets visible star to 0
        if (score >= level.score1Star && score < level.score2Star)// if the score is more than the score1Star and less than the score2star 
        {
            visibleStar = 1;// will make the visible star 1
        }
        else if(score>= level.score2Star && score < level.score3Star)// if the score is more than the score2star and less than the score3star
        {
            visibleStar = 2;//will make visible star 2
        }
        else if (score >= level.score3Star)// if the score is greater or equal to score3star
        {
            visibleStar = 3;// will make visible star 3
        }
        starIndex = visibleStar;// visible star would be equal to the star index
        UpdateStars();// update the stars after all of the code
    }
    public void SetTarget(int target)// functtion for the set target
    {
        targetText.text = target.ToString();//makes target to a string ""
    }
    public void SetRemaining(int remaining)// function for the remaining moves
    {
        remainingText.text = remaining.ToString();// makes the remaining to a string ""
    }
    public void SetRemaining(string remaining)//function for the set remaining
    {
        remainingText.text = remaining;// makes the remaining text to remaining
    }
    public void SetLevelType(Level.LevelType type)//sets the level type 
    {
      switch (type)// switch case for type
      {
            case Level.LevelType.MOVES:
                   remainingSubtext.text = "moves remaining";
                   targetSubtext.text = "target score";
                   break;
            case Level.LevelType.OBSTACLE:
                    remainingSubtext.text = "moves remaining";
                    targetSubtext.text = "dishes remaining";
                    break;
            case Level.LevelType.TIMER:
                    remainingSubtext.text = "time remaining";
                    targetSubtext.text = "target score";
                    break;
      }
        
    }

    public void OnGameWin(int score)// function for ongame win
    {
        isGameOver = true;// will make isGameOver true when it is called
    }

    public void OnGameLose()// function for ongame lose
    {
        isGameOver = false;// will make isgameover false when called
    }
}
