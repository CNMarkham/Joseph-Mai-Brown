using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {

    }
 
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("coin"))
        {
            Destroy(door);
            Destroy(other.gameObject);
            
            Debug.Log("Trigger Enter");
        }
        
    }
}
