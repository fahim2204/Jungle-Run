using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public ScoreManager scoreManager;
    public AudioSource backGroundSound;
    public AudioSource deathSound;

    private Vector3 playerStartingPoint;
    private Vector3 groundGenerationStartPoint;

    public GroundGenerator groundGenerator;
    public GameObject largeGround;
    public GameObject mediumGround;

    public GameObject gameOverScreen;

    public AudioSource clickSound;




    void Start()
    {
        playerStartingPoint = player.transform.position;
        groundGenerationStartPoint = groundGenerator.transform.position;
        gameOverScreen.SetActive(false);
    }
    public void GameOver()
    {
        gameOverScreen.gameObject.SetActive(true);
        scoreManager.isScoreIncreasing = false;
        backGroundSound.Stop();
        deathSound.Play();
        player.gameObject.SetActive(false);
        scoreManager.scoreText.gameObject.SetActive(false);
        scoreManager.scoreLabel.gameObject.SetActive(false);
        scoreManager.hiScoreText.gameObject.SetActive(false);
        scoreManager.hiScoreLabel.gameObject.SetActive(false);


    }

    public void Quit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        GroundDestroyer[] destroyer = FindObjectsOfType<GroundDestroyer>();
        for(int i=0;i<destroyer.Length;i++)
        {
            destroyer[i].gameObject.SetActive(false);
        }
        largeGround.SetActive(true);
        mediumGround.SetActive(true);
        player.transform.position = playerStartingPoint;
        groundGenerator.transform.position = groundGenerationStartPoint;
        gameOverScreen.SetActive(false);
        player.gameObject.SetActive(true);
        backGroundSound.Play();
        scoreManager.score = 0;
        scoreManager.isScoreIncreasing = (true);
        clickSound.Play();

        scoreManager.scoreText.gameObject.SetActive(true);
        scoreManager.scoreLabel.gameObject.SetActive(true);
        scoreManager.hiScoreText.gameObject.SetActive(true);
        scoreManager.hiScoreLabel.gameObject.SetActive(true);


    }

    
}
