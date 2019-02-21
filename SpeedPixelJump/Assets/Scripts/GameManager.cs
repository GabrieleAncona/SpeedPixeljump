using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public HUDManager hd;
    public SpeedBar bar;

	// Use this for initialization
	void Start () {

        hd = FindObjectOfType<HUDManager>();
        bar = FindObjectOfType<SpeedBar>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
