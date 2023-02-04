using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioClip lvlUpSound;
    GameManager gameManager;
    LevelManager levelManager;
    int count;
    int lvlCount;

    private void Start()
    {
        gameManager = GameManager.instance;
        count = gameManager.killCount;

        levelManager = LevelManager.Instance;
        lvlCount = levelManager.currentLevel;
    }

    private void Update()
    {
        if (count < gameManager.killCount)
        {
            source.PlayOneShot(clip);
            count = gameManager.killCount;
        }

        if (lvlCount % 5 == 0)
        {
            source.PlayOneShot(lvlUpSound);
        }
    }

}