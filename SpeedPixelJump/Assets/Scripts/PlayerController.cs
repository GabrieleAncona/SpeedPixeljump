using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float Speed;
    public float JumpForce;
    public Transform posizione;
    public int Count;
    public bool isGrounded;
    public Rigidbody rb;
    public SpeedBar sb;
   // public Transform GetPosizione;
    public Transform end;
    public float dist;

    // Use this for initialization
    void Start () {

        posizione = GetComponent<Transform>();
       // end = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        sb = FindObjectOfType<SpeedBar>();
       // GetPosizione = GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {

        Movement();
        Jump();
        SetPosition();
       
     }

    public void Movement()
    {
        if (Time.timeScale == 1)
        {
            //posizione.position += Vector3.right * Speed;
            //errore
            posizione.position = posizione.position + new Vector3(Speed, 0.0f, 0.0f);
            Speed -= 0.001f;
        }
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Count < 3)
        {
            rb.AddForce(new Vector3(0.0f, JumpForce, 0.0f));
            Count++;
            
        }
    }

    public void SetPosition()
    {
        //float x = (float)posizione.position.X;
          dist = Vector3.Distance(posizione.position, end.position);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Piano")
        {
            Count = 0;
        }
    }


}
