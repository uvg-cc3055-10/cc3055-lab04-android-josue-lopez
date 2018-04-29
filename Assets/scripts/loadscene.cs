using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadscene : MonoBehaviour {
	// Use this for initialization
	void Start () {
        
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void LoadScene()
    {
        SceneManager.LoadScene("scene1");
    }
}
