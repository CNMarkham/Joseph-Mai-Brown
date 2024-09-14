using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LifeHUD : MonoBehaviour
{
    private GameObject[] hearts;
    private int lives = 3;
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        hearts = GameObject.FindGameObjectsWithTag("heart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HurtPlayer()
    {
        Debug.Log("Ouch!");
        lives -= 1;
        hearts[lives].SetActive(false);
        if (lives == 0)
        {
            background.GetComponent<GameManager>().GameOver();
        }
    }
    public void HealPlayer()
    {
        Debug.Log("Yay!");
        if(lives < 3)
        {
            hearts[lives].SetActive(true);
            lives += 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Gem"))
        {
            HealPlayer();
        }
    }
}
