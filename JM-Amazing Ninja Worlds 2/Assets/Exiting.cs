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
        Debug.Log("collision_Detecter");// debugs to check the collision for the teleport pad 
        Debug.Log($"gemGreem detecting hierarchy: {gemGreen.activeInHierarchy}");// debug logs to check the gemgreen in the hierchary
        if (gemGreen.activeInHierarchy == false)//if the green gem is not activated in the hierarchy
        {
            
            background.GetComponent<GameManager>().TeleportOpen(Destination); // gets the game manager component in the background for telporting
        }
    }
}
