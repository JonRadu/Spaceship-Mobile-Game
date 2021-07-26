using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class PointCounter : MonoBehaviour
{

    public Text countText;
    public int coinnumber;
    private int count;

    // Use this for initialization
    void Start()
    {
        count = 0;
        SetCountText();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Score:" + count.ToString() + "/" + coinnumber;
    }
}

