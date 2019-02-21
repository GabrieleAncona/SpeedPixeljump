using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float Speed = 0.05f;
    public Transform posizione;

	// Use this for initialization
	void Start () {

        posizione = GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {
		
         if (Time.timeScale == 1)
        {
            posizione.position += Vector3.left * Speed;
            Speed -= 0.0001f;
        }

	}
}
