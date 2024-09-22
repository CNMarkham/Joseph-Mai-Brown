using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject gem;//public gameobject of gem
    public GameObject background;// gets the gameobject background
    public string teleportDestination;// public string of teleport destination

    private void OnTriggerEnter(Collider other)// if something else triggers the teleport pad
    {
        if(gem.activeInHierarchy == false) // if the gem in the hierarchy is false
        {
            background.GetComponent<GameManager>().TeleportOpen(teleportDestination); // gets the game manager in the background
                                                                                      // finds the destination for the teleport
        }
        
    }
}
