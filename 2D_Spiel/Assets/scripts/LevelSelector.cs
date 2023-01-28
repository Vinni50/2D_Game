using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour {

	public string sceneToLoad;

	// Use this for initialization
	void Start () {
		// Level 01 auf aktiv schalten
		PlayerPrefs.SetInt("scene00", 1);

		if (PlayerPrefs.GetInt (sceneToLoad.ToString ()) == 1)
		{
			// Level aktiv => Button aktivieren
			this.GetComponent<Button>().interactable = true;
		}
		else
		{
			// Level inaktiv => Button deaktivieren
			this.GetComponent<Button>().interactable = false;
		}

	}

	// Update is called once per frame
	void Update () {

	}

    public void LoadLevel()
	{
		// ausgewähltes Level laden
		SceneManager.LoadScene(sceneToLoad);
	}
}
