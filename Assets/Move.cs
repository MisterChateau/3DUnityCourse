﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.5f;
    public int rotateSpeed = 60;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }
    }
}
