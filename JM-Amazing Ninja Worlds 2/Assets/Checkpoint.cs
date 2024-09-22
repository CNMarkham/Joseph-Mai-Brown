using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject background;// makes the background a publix gmae object
    private void OnTriggerEnter(Collider other)// if something else triggers this object
    {
        Vector3 newCheckpoint = transform.position; //finds the position of the new checkpoint
        background.GetComponent<GameManager>().checkPoint = newCheckpoint; // gets the background gamemanager to make the checkpoint equal to the
                                                                           // new checkpoint
                                                                           
    }
}
