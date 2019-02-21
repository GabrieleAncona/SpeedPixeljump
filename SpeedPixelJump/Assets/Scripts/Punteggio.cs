using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Punteggio : MonoBehaviour {
    public Text score;
    public PlayerController player;

	// Use this for initialization
	void Start () {

        player = FindObjectOfType<PlayerController>();
        score = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {

        score.text = player.Speed.ToString();
        Death();

	}

    public void Death()
    {

        if(player.Speed <= 0.0f)
        {
            SceneManager.LoadScene("GameOver");
            Debug.Log("morte");
        }

    }

}
