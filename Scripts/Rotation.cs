using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public int val_min;
    public int val_max;
    float speed;
    private void Start()
    {
        speed = Random.Range(val_min, val_max);
    }
    void Update()
    {
    
        transform.Rotate(0, 0, speed);
    }
}
