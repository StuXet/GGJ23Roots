using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;
    GameManager gameManager;


    private void Start()
    {
       gameManager = GameManager.instance;
    }
    public void Spawn()
    {
        int prefabIndex = Random.Range(0, LevelManager.Instance.spawnVariety);
        if (prefabIndex > prefabs.Length)
        {
            prefabIndex = prefabs.Length - 1;
        }
        GameObject worm = Instantiate(prefabs[prefabIndex], transform.position, transform.rotation);
        Bird.Instance.worms.Add(worm.GetComponent<Enemy>());
    }
}