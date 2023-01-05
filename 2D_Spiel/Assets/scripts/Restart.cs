using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; //Wichtig Importieren
using UnityEngine;

public class Restart : MonoBehaviour
{
    // Methode
    void OnTriggerEnter2D(Collider2D other)
    {
     

        if(other.tag == "Player")
        {
            Debug.Log("Spieler Tot");

            //Neustart der Scene
            SceneManager.LoadScene("Scene01");
        }
    }


}
