using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroids : MonoBehaviour {

    public static float scrollingSpeed = 2f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.down * scrollingSpeed * Time.deltaTime);
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
