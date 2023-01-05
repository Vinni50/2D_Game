using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{

    public string sceneToLoad;



    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel()
    {
        // ausgewähltes Level laden
        SceneManager.LoadScene(sceneToLoad);
    }
}