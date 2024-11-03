using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject screenParent;
    public GameObject scoreParent;
    public TMP_Text loseText;
    public TMP_Text scoreText;
    public Image[] stars;
    private Animator animator;
    // Start is called before the first frame update
    private void Start()
    {
        screenParent.SetActive(false);// makes screen parent false

        for (int i = 0; i < stars.Length; i++)// loops till i is less than the stars legnth which is 3
        {
            stars[i].enabled = false;// sets the stars array to false
        }
        animator = GetComponent<Animator>();//gets the animator component
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowLose()
    {
        screenParent.SetActive(true);//sets the screen partent to true
        scoreParent.SetActive(false);// sets the score parent to false
        loseText.enabled = true;// enabled the lose text

        if (animator)
        {
            animator.Play("GameOverDisplay");// plays the game over display animation
        }
    }    

    public void ShowWin(int score, int starCount)
    {
        screenParent.SetActive(true);// makes screen parent true
        scoreParent.SetActive(true);//makes score parent to true
        loseText.enabled = false;// disabled the lose text
        scoreText.text = score.ToString();// makes the score text to score string
        scoreText.enabled = false; // disabled the score text
        if (animator)
        {
            animator.Play("GameOverShow");// pklays the gameovershow animator
        }
        StartCoroutine(ShowWinCoroutine(starCount));// makes a coroutine which plays it in different timings
    }

    private IEnumerator ShowWinCoroutine(int starCount)//ienumerator for the couritine
    {
        if (starCount < stars.Length)// if the star count is less than star length
        {
            for (int i = 0; i <= starCount; i++)// will make a loop till i is less than the star count
            {
                stars[i].enabled = true;// will make stars enabled
                if (i > 0)// if i is greater than zero
                {
                    stars[i - 1].enabled = false;// will take i and subtract 1 from it than make it disabled
                }

                yield return new WaitForSeconds(0.5f);// will wait half a second before playing
            }
        }

        scoreText.enabled = true;// enables the score texxt after waiting a half a second for the stars to show
    }

    public void OnReplayClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);// will get the active screne that was playing and load it
    }

    public void OnDoneClicked()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}   
