using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public Button pausebtn;
    public Button resumebtn;
    public GameObject pausemenu;
    private bool ispaused = false;
    public GameObject ship;
    public GameObject pausehidebtn;
    public GameObject fire;
    public GameObject fire1;
    public GameObject fire2;
    public GameObject shipscr;
    public string mousescript;


    void Start()
    {
        Button btnp = pausebtn.GetComponent<Button>();
        btnp.onClick.AddListener(pauseClick);
        Button btnr = resumebtn.GetComponent<Button>();
        btnr.onClick.AddListener(resumeClick);

    }

    void pauseClick()
    {
        (shipscr.GetComponent(mousescript) as MonoBehaviour).enabled = false;
        pausemenu.gameObject.SetActive(true);
        ispaused = true;
        pausehidebtn.gameObject.SetActive(false);
            //ship.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        fire.gameObject.SetActive(false);
        fire1.gameObject.SetActive(false);
        fire2.gameObject.SetActive(false);
    }
    void resumeClick()
    {
        (shipscr.GetComponent(mousescript) as MonoBehaviour).enabled = true;
        pausemenu.gameObject.SetActive(false);
        ispaused = false;
        pausehidebtn.gameObject.SetActive(true);
        //ship.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        fire.gameObject.SetActive(true);
        fire1.gameObject.SetActive(true);
        fire2.gameObject.SetActive(true);

    }

    void Update()
    {
        if (ispaused==true)
        {
        Time.timeScale = 0;
            

        }
        else
            Time.timeScale = 1;


    }
}
