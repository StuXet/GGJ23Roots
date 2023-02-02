using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public float initialDelay = 1f;
    public float spawnInterval = 2f;
    public float intervalDecrease = 0.1f;

    private float currentInterval;
    private float timer;

    void Start()
    {
        currentInterval = spawnInterval;
        timer = initialDelay;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            int prefabIndex = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[prefabIndex], transform.position, transform.rotation);
            timer = currentInterval;
            currentInterval -= intervalDecrease;
        }
    }
}