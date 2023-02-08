using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Platformer.PlayerMovement;

public class StartOnClick : MonoBehaviour
{

    public string sceneName;

    public void StartLevel()
    {
        //PlayerMovement.GameIsPaused = false;
        SceneManager.LoadScene(sceneName);
    }
}