using UnityEngine;
using TMPro; // Required for TextMeshPro
public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component

    private static ScoreDisplay instance;

    void Awake()
    {
        instance = this;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public static void UpdateScore(int score)
    {
        // Update the text to display the current score
        instance.scoreText.text = "Score: " + score;
    }
}