using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BonusTemp : MonoBehaviour {
    public SpeedBar sBar;
    public PlayerController sp;

	// Use this for initialization
	void Start () {

        sBar = FindObjectOfType<SpeedBar>();
        sp = FindObjectOfType<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
                //sBar.currentSpeed -= 50f;
                sp.Speed += 0.05f;
                Destroy(this.gameObject);
        }
    }

}
