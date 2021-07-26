using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour
{
    public GameObject death;
    public GameObject ship;
    public GameObject fire;
    public GameObject fire1;
    public GameObject fire2;
    public GameObject score;
    public GameObject level;
    public GameObject coins;
    public GameObject asteroids;
    public GameObject Explozie_Anim;
    public GameObject finish;
    public GameObject pausebtn;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        if (other.gameObject.CompareTag("GameOver"))
        {
            GameObject explozie = Instantiate(Explozie_Anim) as GameObject;
            explozie.transform.position = transform.position;
            Destroy(other.gameObject);
            //StartCoroutine(menuscript.Deathactive());
            //active = false;
            //this.gameObject.SetActive(false);
            ship.GetComponent<SpriteRenderer>().enabled = false;
            asteroids.gameObject.SetActive(false);
            fire.gameObject.SetActive(false);
            fire1.gameObject.SetActive(false);
            fire2.gameObject.SetActive(false);
            coins.gameObject.SetActive(false);
            score.gameObject.SetActive(false);
            level.gameObject.SetActive(false);
            finish.gameObject.SetActive(false);
            pausebtn.gameObject.SetActive(false);
            StartCoroutine(Deathactive());

        }

    }

    public IEnumerator Deathactive()
    {
        yield return new WaitForSeconds(1f);
        death.gameObject.SetActive(true);
    }
}