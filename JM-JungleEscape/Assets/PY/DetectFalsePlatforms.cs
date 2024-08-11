using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;
    public LayerMask Plateform;
    void Update()
    {

        hit = Physics.Raycast(transform.position, transform.forward, 1.5f);
        Debug.DrawRay(transform.position, transform.forward * 1.5f, Color.yellow);

        if (hit == true)
        {
            Debug.LogWarning("Be careful!");
        }
        else
        {
            Debug.Log("All clear!");
        }
    }
   
}
