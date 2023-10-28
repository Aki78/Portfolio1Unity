using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour{

    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void Awake(){
        scoreText.text = "Score: 0";
        if(instance == null){
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points){
        score += points;
        UpdateScoreUI();
    }

    private void UpdateScoreUI(){
        scoreText.text = "Score: " + score;
    }
}

