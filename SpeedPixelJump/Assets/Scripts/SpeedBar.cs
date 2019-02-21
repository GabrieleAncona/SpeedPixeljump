using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpeedBar : MonoBehaviour {
    public Slider speedBar;
    public float speed = 0;
    public float currentSpeed;
    public PlayerController player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        currentSpeed = player.Speed;
        
	}
	
	// Update is called once per frame
	void Update () {

        LostTime();
        Morte();

	}

    public void LostTime()
    {
        if(currentSpeed >= 0 && Time.timeScale == 1)
        currentSpeed += 0.1f;
        speedBar.value = currentSpeed;
        if (currentSpeed <= 0)
        {
            currentSpeed = 0;
            speedBar.value = currentSpeed;
        }
    }

    public void Morte()
    {
        if (speedBar.value == 100f)
        {
            Debug.Log("gameover");
        }
    }

}
