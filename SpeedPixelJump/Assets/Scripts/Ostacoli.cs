using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacoli : MonoBehaviour {
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6 , prefab7 ;
    public float spawnRate = 2f;
    private float nextSpawn = 0f;
    private int Spawn;

    // Use this for initialization
    void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
	
        if(Time.time > nextSpawn)
        {
            Spawn = Random.Range(1, 7);

            switch (Spawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(prefab5, transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(prefab6, transform.position, Quaternion.identity);
                    break;
             
            }

            nextSpawn = Time.time + spawnRate;

        }

	}

}
