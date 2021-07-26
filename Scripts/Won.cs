using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Won : MonoBehaviour
{
    public GameObject Won_anim;
    public GameObject score;
    public GameObject level;
    public GameObject win;
    public GameObject ship;
    public GameObject fire;
    public GameObject fire1;
    public GameObject fire2;
    public GameObject pausebtn;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Won"))
        {
            GameObject won = Instantiate(Won_anim) as GameObject;
            won.transform.position = ship.transform.position;
            Destroy(other.gameObject);

            score.gameObject.SetActive(false);
            level.gameObject.SetActive(false);
            pausebtn.gameObject.SetActive(false);
            StartCoroutine(Winactive());



        }

    }
    public IEnumerator Winactive()
    {
        yield return new WaitForSeconds(1f);
        win.gameObject.SetActive(true);
        ship.GetComponent<SpriteRenderer>().enabled = false;
            fire.gameObject.SetActive(false);
            fire1.gameObject.SetActive(false);
            fire2.gameObject.SetActive(false);

    }

}
