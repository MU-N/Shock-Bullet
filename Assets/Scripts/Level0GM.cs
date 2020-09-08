using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level0GM : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Diffculty;
    public GameObject help;


    void Start()
    {
        MainMenu.SetActive(true);
        Diffculty.SetActive(false);
        help.SetActive(false);
;

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            MainMenu.SetActive(true);

        }
    }


    public void HandelPlayButton()
    {
        MainMenu.SetActive(false);
        Diffculty.SetActive(true);
    }

    public void HandelHelpButton()
    {
        MainMenu.SetActive(false);
        help.SetActive(true);
    }

    public void HandelEasyButton()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void HandelMediumButton()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void HandelHardButton()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void HandelQuitButton()
    {
        Application.Quit();
    }




}
