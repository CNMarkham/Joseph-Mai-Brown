﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPY : MonoBehaviour
{
    float rotSpeed = -5f;

    void FixedUpdate()
    {
        //constantly rotate object
        transform.Rotate(0, 0, rotSpeed);
    }
}
