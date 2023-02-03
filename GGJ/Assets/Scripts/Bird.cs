using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float hitInterval = 2;
    public int strength = 1;
    float timer;
   
    // Start is called before the first frame update
    void Start()
    {
        timer = hitInterval;
    }

    // Update is called once per frame
    void Update()
    {
        hitCycle();
    }

    void hitCycle()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            hit();
            timer = hitInterval;
        }
    }

    void hit()
    {
        Enemy tar = SpawnManager.Instance.worms[Random.Range(0, SpawnManager.Instance.worms.Count)];
        tar.health -= strength;
    }

}
