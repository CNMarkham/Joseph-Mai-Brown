using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupkey : MonoBehaviour
{
    public ParticleSystem teleportDust;// public particle system for dust
    private void OnTriggerEnter(Collider other)// if something collides with the gem
    {
        gameObject.SetActive(false);// sets the gameobject(gem) to false
        teleportDust.Play();// plays the dust animation
    }
}
