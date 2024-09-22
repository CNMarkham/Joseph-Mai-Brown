using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public ParticleSystem teleportDust;// public particle system for the dust
    private void OnTriggerEnter(Collider other)//if something collides with the teleport pad
    {
        gameObject.SetActive(false);// sets the game object false
        teleportDust.Play();// plays the dust animation
    }
}
