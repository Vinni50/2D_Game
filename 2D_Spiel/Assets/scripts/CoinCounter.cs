using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int geld;
    public Text money;

    // Start is called before the first frame update
    void Start()
    {
        if (money == null)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (money != null)
        {
            money.text = geld.ToString();
        }
    }

    public void Addmoney()
    {
        geld++;
    }
}