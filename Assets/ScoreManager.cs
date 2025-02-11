using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public int CurrentScore = 0;
    public Text ScoreText;
    
    
    public void AddScore(int score)
    {
        CurrentScore += score;

        if (ScoreText)
        {
            ScoreText.text = "Score: " + CurrentScore.ToString();
        }
    }

    public void FinalScore()
    {

    }
        
}
