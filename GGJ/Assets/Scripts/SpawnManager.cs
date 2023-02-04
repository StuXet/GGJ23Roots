using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]List<Spawner> spawners = new List<Spawner>();
    public float spawnInterval = 1;
    float timer;
    [HideInInspector] public List<Enemy> worms;
    private static SpawnManager instance;
    public static SpawnManager Instance { get { return instance; } }

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

        //DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        timer = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        RunSpawns();
    }

    void RunSpawns()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            spawners[Random.Range(0, spawners.Count)].Spawn();
            timer = spawnInterval;
        }
    }
}
