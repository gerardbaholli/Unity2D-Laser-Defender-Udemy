using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{

    private TextMeshProUGUI healthText;
    private Player player;

    private void Start()
    {
        healthText = GetComponent<TextMeshProUGUI>();
        player = FindObjectOfType<Player>();
    }

    private void FixedUpdate()
    {
        healthText.text = player.GetHealth().ToString();
    }

}
