using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDManager : MonoBehaviour {
    public GameManager gm;
    public SpeedBar sb;
    public ProgressBar pb;

	// Use this for initialization
	void Start () {

        gm = FindObjectOfType<GameManager>();
        sb = FindObjectOfType<SpeedBar>();
        pb  = FindObjectOfType<ProgressBar>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
