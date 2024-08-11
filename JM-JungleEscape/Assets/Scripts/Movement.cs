using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    float movementSpeed = 2;

    bool canRotateR;
    bool canRotateL;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        transform.eulerAngles = new Vector3(0, 90 * horizontal, 0);
        speed = Mathf.Clamp((Input.GetAxisRaw("Vertical") + Mathf.Abs(horizontal)), -1, 1) * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, speed);
    }
}
