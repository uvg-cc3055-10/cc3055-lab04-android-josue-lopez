using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {
    public GameObject asteroids;
    public float spawntime = 4f;
    public float time = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.estado == false)
        {
            if (time < spawntime)
            {
                time += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-2f, 2f);
                Instantiate(asteroids, new Vector3(random, 5, 0), Quaternion.identity);
                time = 0;
            }
        }
        
		
	}
}
