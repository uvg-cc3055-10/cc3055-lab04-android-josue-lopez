using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public bool estado = false;
    public static GameController instance;
    public Text Score;
    public float time = 0;
	// Use this for initialization
	void Start () {
        instance = this;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (estado == false)
        {
            time += Time.deltaTime;
            Score.text = time.ToString();
        }
        

    }
}
