using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour {

	public string sceneToLoad;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Debug.Log ("Nächstes Level");
			// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
			LoadLevel();
		}
	}

	void LoadLevel()
	{
		// nächste Szene laden
		SceneManager.LoadScene(sceneToLoad);
		// fortschritt speichern
		if (PlayerPrefs.GetInt (sceneToLoad.ToString ()) == 0) {
			// level noch nicht aktiv -> freischalten
			PlayerPrefs.SetInt (sceneToLoad.ToString (), 1);
			Debug.Log (" PlayerPrefs " + PlayerPrefs.GetInt (sceneToLoad.ToString ()));
		}

	}
}