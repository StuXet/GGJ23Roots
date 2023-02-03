using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spray : MonoBehaviour
{
    public int damage;
    public float dmgInterval;



    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = dmgInterval;
    }

    // Update is called once per frame
    void Update()
    {
        SprayCycle();
    }

    void SprayCycle()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            foreach (var item in SpawnManager.Instance.worms)
            {
                item.health -= damage;
            }
            timer = dmgInterval;
        }
    }
}
