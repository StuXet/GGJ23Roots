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
        int prefabIndex = Random.Range(0, gameManager.currentLvl);
        GameObject worm = Instantiate(prefabs[prefabIndex], transform.position, transform.rotation);
        WormKiller.Instance.worms.Add(worm.GetComponent<Enemy>());
    }
}