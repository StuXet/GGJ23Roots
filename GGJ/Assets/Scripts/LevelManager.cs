using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public int spawnVariety = 0;
    int currentLevel = 1;
    public Text currentLevelText;
    [SerializeField] float levelIncreaseTime;
    float timer;
    GameManager gameManager;

    [SerializeField]GameObject[] treeLevels;
    [SerializeField]GameObject[] treeLevelsLogo;
    int treeLvlCounter = 0;

    private static LevelManager instance;
    public static LevelManager Instance { get { return instance; } }
    private void Awake()
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
        UpdateLevel();
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        CheckLevel();
    }

    void CheckLevel()
    {
        if (timer >= levelIncreaseTime) 
        {
            LevelUp();
            if (currentLevel % 2 == 0)
            {
                spawnVariety++;
            }
            if (currentLevel % 5 == 0 || !(treeLvlCounter >= 5))
            {
                UpdateTree();
            }
            timer = 0; 
            SpawnManager.Instance.spawnInterval *= 0.8f;
        }
    }

    public void LevelUp()
    {
        gameManager.maxHealth += 50;
        gameManager.currentHealth = gameManager.maxHealth;
        currentLevel++;
        UpdateLevel();
    }

    public void UpdateLevel()
    {
        currentLevelText.text = "Level: " + currentLevel;
    }

    void UpdateTree()
    {
        if (treeLvlCounter <= 3)
        {
            treeLevels[treeLvlCounter].SetActive(false);
            treeLevelsLogo[treeLvlCounter].SetActive(false);
            treeLvlCounter++;
        }

        if (treeLvlCounter <= 4)
        {
            treeLevels[treeLvlCounter].SetActive(true);
            treeLevelsLogo[treeLvlCounter].SetActive(true);
        }

    }

}
