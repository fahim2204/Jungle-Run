using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float pointPerSecond;
    public Text scoreText;
    public Text scoreLabel;
    public Text hiScoreText;
    public Text hiScoreLabel;

    public Text LastScoreText;
    public Text LastScoreLabel;


    public float score;
    private float hiScore;
    public bool isScoreIncreasing;

    void Start()
    {
        isScoreIncreasing = true;
        if (PlayerPrefs.HasKey("HighScore"))
            hiScore = PlayerPrefs.GetFloat("HighScore");
    }

    void Update()
    {
        if(isScoreIncreasing)
          score += pointPerSecond * Time.deltaTime;

        if(score>hiScore)
        {
            hiScore = score;
            PlayerPrefs.SetFloat("HighScore", hiScore);
        }
        scoreText.text = Mathf.Round(score).ToString();
        LastScoreText.text = Mathf.Round(score).ToString();
        hiScoreText.text = Mathf.Round(hiScore).ToString();

    }
}
