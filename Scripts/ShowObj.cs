using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObj : MonoBehaviour
{
    private Vector2 screenbounds;


    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

        
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }
    void Update()
    {
        if (transform.position.y < screenbounds.y * -1.1)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

}
