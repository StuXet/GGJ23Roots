using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormKiller : MonoBehaviour
{
    public List<Enemy> worms;
    public float hitInterval = 2;
    public int strength = 1;
    public bool isActive;
    float timer;

    private static WormKiller instance;
    public static WormKiller Instance { get { return instance; } }

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
        if (isActive)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                hit();
                timer = hitInterval;
            }
        }
    }

    void hit()
    {
        Enemy tar = worms[Random.Range(0, worms.Count)];
        tar.health -= strength;
    }
}
