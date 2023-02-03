using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public int wormMaxLVL;
    public float killInterval;

    float timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = killInterval;
    }

    // Update is called once per frame
    void Update()
    {
        KillCycle();
    }

    void KillCycle()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Enemy tar = SpawnManager.Instance.worms[Random.Range(0, SpawnManager.Instance.worms.Count)];
            if (tar.level <= wormMaxLVL)
            {
                tar.health -= tar.health;
                timer = killInterval;
            }
        }
    }

}
