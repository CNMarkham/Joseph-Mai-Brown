using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public ParticleSystem explosion;
    public ParticleSystem trail;

    public void GameOver()
    {
        
        gameObject.SetActive(false);
        Invoke("Reload", 1);
      
        explosion.transform.position = transform.position;
        explosion.Play();
    }
    void Reload()
    {
        SceneManager.LoadScene(2);
    }
   

    void Start()
    {
        explosion.Stop();
    }
    
}


