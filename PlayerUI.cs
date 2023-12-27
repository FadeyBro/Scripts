using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    public Slider healthBar;
    public TextMeshProUGUI CoinsCounter;

    public Health health;
    public CoinsCounter coins;
    private void Start()
    {
        healthBar.maxValue = health.maxhealth;
        healthBar.value = health.health;
        CoinsCounter.text = "coins" + coins.coin;

    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health.health;
        CoinsCounter.text = "coins" + coins.coin;
    }
}
