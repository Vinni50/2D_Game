using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public int geld;
    public TextMeshProUGUI money;

    // Start is called before the first frame update
    void Start()
    {
        geld = PlayerPrefs.GetInt("Money",0);

        if (money == null)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (money != null)
        {
            money.text = PlayerPrefs.GetInt("Money", 0).ToString();
        }
    }

    public void Addmoney()
    {
        geld++;
        PlayerPrefs.SetInt("Money",geld);
    }
}