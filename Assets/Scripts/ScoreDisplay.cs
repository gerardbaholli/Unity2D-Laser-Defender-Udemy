using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{

    private TextMeshProUGUI scoreText;
    private GameSession gameSession;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        gameSession = FindObjectOfType<GameSession>();
    }

    private void FixedUpdate()
    {
        scoreText.text = gameSession.GetScore().ToString();
    }

}
