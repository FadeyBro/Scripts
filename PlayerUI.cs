using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    public Slider healthBar;
    public TextMeshProUGUI CoinsCounter;
    public PlayerMovementScript player;
    private void Start()
    {
        healthBar.maxValue = player.maxhealth;
        healthBar.value = player.health;
        CoinsCounter.text = "coins" + player.coins;

    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = player.health;
        CoinsCounter.text = "coins" + player.coins;
    }
}
