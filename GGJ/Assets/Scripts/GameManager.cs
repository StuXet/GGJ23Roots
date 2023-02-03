using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    public int playerDamage = 1;
    public int currentLvl = 1;
    bool isrunning = true; 

    private int score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Points: " + score;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        isrunning = false;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        isrunning = true;
    }
}