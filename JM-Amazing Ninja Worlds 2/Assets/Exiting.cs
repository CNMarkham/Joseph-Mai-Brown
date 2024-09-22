using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exiting : MonoBehaviour
{
    public GameObject gemGreen; //public gameobject of green gem
    public GameObject background; //public gameobject of the background
    public string Destination; //string for the destination 

    private void OnTriggerEnter(Collider other)// when something collides with the teleport pad
    {
        Debug.Log("collision_Detecter");
        Debug.Log($"gemGreem detecting hierarchy: {gemGreen.activeInHierarchy}");
        if (gemGreen.activeInHierarchy == false)//if the green gem is not activated in the hierarchy
        {
            
            background.GetComponent<GameManager>().TeleportOpen(Destination); // gets the game manager component for telporting to the destination
        }
    }
}
