using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int score = 0; // The current score

    public static void AddPoints(int points)
    {
        score += points;
        ScoreDisplay.UpdateScore(score);
    }

    // Reset score to zero
    public static void ResetScore()
    {
        score = 0;
        ScoreDisplay.UpdateScore(score);
    }
}
