using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    GameManager gameManager;
    int count;

    private void Start()
    {
        gameManager = GameManager.instance;
        count = gameManager.killCount;   
    }

    private void Update()
    {
        if (count < gameManager.killCount)
        {
            source.PlayOneShot(clip);
            count = gameManager.killCount;
        }
    }

}