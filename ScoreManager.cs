using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    void Start()
    {
        scoreText.text = score.ToString();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
            score++;
            scoreText.text = score.ToString();
    }
}
