﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
    public Vector2 direction;

	// Use this for initialization
	void Start () {
        direction = Vector2.up;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
        GetInput();
	}
    public void Move() 
    {
        transform.Translate(direction*speed*Time.deltaTime);
    }
    private void GetInput()
    {
        direction += Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }
}
