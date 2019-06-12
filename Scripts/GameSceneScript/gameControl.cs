using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameControl : MonoBehaviour
{

    private bool status = false;

    [Tooltip("This area determine ParticleSystem of ball")]
    public ParticleSystem system;
    [Tooltip("This area determine Play and Pause state of ball")]
    public Button button;
    [Tooltip("This area determine Sprite of button")]
    public Sprite play, pause;
    RectTransform rectTransform;

    void Start()
    {
        button.image.sprite = play;
        Time.timeScale = 0f;
        system.Stop();      
        rectTransform = button.GetComponent<RectTransform>();
    }
    
    public void gameStatus()
    {
        if (status)
        {
            Time.timeScale = 0f;
            status = false;
            system.Stop();
            button.image.sprite = play;
            rectTransform.Rotate(new Vector3(0, 0, 90));
        }
        else
        {
            Time.timeScale = 1f;
            status = true;
            system.Play();
            button.image.sprite = pause;
            rectTransform.Rotate(new Vector3(0, 0, -90));
        }
    }

    public void GoHome()
    {
        SceneManager.LoadScene(0);

    }


}
