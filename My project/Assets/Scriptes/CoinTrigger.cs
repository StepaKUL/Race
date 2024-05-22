using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    public TMP_Text coinsText;
    private int coins = 0;
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Coin")
        {
            coins++;
            coinsText.text = coins.ToString();
            int money = PlayerPrefs.GetInt("money");
            PlayerPrefs.SetInt("money", money + 1);
            Destroy(coll.gameObject);
        }
    }
}
