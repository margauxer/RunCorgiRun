using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text TimeText;
    public CanvasGroup StartScreenCanvasGroup;
    public CanvasGroup GameOverScreenCanvasGroup;
    public GameTimer GameTimer;
    
    public void SetScoreText()
    {
        scoreText.text = "Score: " + ScoreKeeper.GetScore();
    }
    
    public void ResetScoreText()
    {
        scoreText.text = "Score: 0";
    }

    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(StartScreenCanvasGroup);
    }

    public void HideGameOverScreen()
    {
        CanvasGroupDisplayer.Hide(GameOverScreenCanvasGroup);
    }
    
    public void ShowGameOverScreen()
    {
        CanvasGroupDisplayer.Show(GameOverScreenCanvasGroup);
    }
    
    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Show(StartScreenCanvasGroup);
    }

    public void ShowTime()
    {
        TimeText.text = GameTimer.GetTimeAsString();
    }
}
