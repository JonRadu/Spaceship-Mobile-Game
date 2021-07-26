using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsMove : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;


    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }
    void Update()
    {
        if (transform.position.y < screenBounds.y * -1.1)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            
        }
    }
}
