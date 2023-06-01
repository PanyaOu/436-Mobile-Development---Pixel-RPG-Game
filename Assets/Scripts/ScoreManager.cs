using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0; // The current score

    public static void AddPoints(int points)
    {
        score += points;
    }

    // Reset score to zero
    public static void ResetScore()
    {
        score = 0;
    }
}
