using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int maxHealth = 100;
    public int currentHealth;
    public Text scoreText;
    public Text killText;
    public int killCount;
    public int playerDamage = 5;
    bool isrunning = true;
    [HideInInspector] public float wormSpeedDecreaser;

    public int score;

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
        UpdateWormKillText();
    }

    private void Update()
    {
        CheckDeath();
    }

    public void AddKills(int killsToAdd)
    {
        killCount += killsToAdd;
        UpdateWormKillText();
    }

    public void UpdateWormKillText()
    {
        killText.text = "" + killCount;
    }

    public void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "" + score;
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

    void CheckDeath()
    {
        if (currentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {

    }
}