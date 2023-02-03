using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int spawnVariety = 0;
    int currentLevel = 1;
    [SerializeField] float levelIncreaseTime;
    float timer;

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
            if (currentLevel % 2 == 0)
            {
                spawnVariety++;
            }
            currentLevel++;
            SpawnManager.Instance.spawnInterval *= 0.8f;
        }
    }
}
