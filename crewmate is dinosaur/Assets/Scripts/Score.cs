using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {

    public TextMeshProUGUI score;
    public int score_num = 0;

    public float scoreDelay = 0.0001f;

    private void Start() {
        InvokeRepeating("ScoreIncrement", scoreDelay, scoreDelay);
    }

    private void Update() {
        score.text = score_num.ToString();
    }

    private void ScoreIncrement() {
        score_num++;
        int score_check = score_num % 100;
        if(score_check == 0 && Time.timeScale < 2) {
            Time.timeScale += 0.2f;
        }

    }

}
