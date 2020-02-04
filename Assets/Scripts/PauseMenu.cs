using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    // Start is called before the first frame update

    private void Start()
    {
        if(GameIsPaused == false)
        {
            Time.timeScale = 0f;
        }
    }
    // Update is called once per frame
    void Update()
    {
       


       if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Retry()
    {
        GameIsPaused = false;
        SceneManager.LoadScene("Lvl1");
    }
    public void Quit()
    {
        Application.Quit();
    }
    

}
