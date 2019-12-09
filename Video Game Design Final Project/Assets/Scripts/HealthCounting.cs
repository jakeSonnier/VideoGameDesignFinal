using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountCoins : MonoBehaviour
{
    private int numCoinsCollected = 0;
    public Text countText;
    // Use this for initialization
    void Start()
    {
        countText.text = "Health: " + numCoinsCollected.ToString();
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            numCoinsCollected += 1;
            countText.text = "Health: " + numCoinsCollected.ToString();
        }
    }
}