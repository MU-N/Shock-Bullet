using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    
    public GameObject Puase;
    public GameObject GameOver;

    void Start()
    {
        Puase.SetActive(false);

        GameOver.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Puase.SetActive(true);
            Time.timeScale = 0f;

        }

        
    }
    public void HandelResumeButton()
    {
        Time.timeScale = 1;
        Puase.SetActive(false);
    }

    public void HandelRestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void HandelQuitButton()
    {
        Application.Quit();
    }





}
