using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int points = 5;
    [SerializeField] GameObject squahAnim;

    public int damage = 10;
    public float speed = 2f;
    public int health = 5;
    public int level;

    private Transform player;
    private RootHealth playerHealth;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("WormTarget").transform;
        playerHealth = player.GetComponent<RootHealth>();
    }

    private void Update()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        Vector3 diff = player.transform.position - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        CheckHealth();
    }

    void CheckHealth()
    {
        if (health <= 0)
        {
            GameManager.instance.AddPoints(points);
            GameManager.instance.AddKills(1);
            SpawnManager.Instance.worms.Remove(this);
            Instantiate(squahAnim, transform);
            Destroy(gameObject);
        }
    }
}