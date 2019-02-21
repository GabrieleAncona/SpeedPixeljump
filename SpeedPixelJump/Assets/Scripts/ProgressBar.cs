using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour {
    public Slider progressBar;
    public float currentProgress;
    public float Progress = 0f;
    
    
    public PlayerController pc;

    // Use this for initialization
    void Start () {
      
        pc = FindObjectOfType<PlayerController>();
       
        //currentProgress = Progress;

        //progressBar.value = 0;
        

    }
	
	// Update is called once per frame
	void Update () {

        progressBar.value = pc.dist;
        Debug.Log(pc.dist);

    }
}
