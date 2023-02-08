using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Platformer.Menu
{
public class Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public string sceneName;

    public GameObject MenuUI;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            Debug.Log ("Hat geklappt");
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
        MenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void StartLevel()
    {
        //PlayerMovement.GameIsPaused = false;
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
 
}
}
