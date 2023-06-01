using UnityEngine;
using TMPro; // Required for TextMeshPro

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component

    void Start()
    {
        // Get the TextMeshProUGUI component
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Update the text to display the current score
        scoreText.text = "Score: " + ScoreManager.score;
    }
}
