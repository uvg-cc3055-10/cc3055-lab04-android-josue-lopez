using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {
    public float speed = 10f;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.estado == false)
        {
            float movX = Input.acceleration.x;
            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
        }
        else
        {
            GameController.instance.estado = true;
            SceneManager.LoadScene("scenemain");

        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.instance.estado = true;
        LoadScene();
        
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("scenemain");
    }

}
