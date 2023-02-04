using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RootHealth : MonoBehaviour
{
    GameManager gameManager;
    

    void Start()
    {
        gameManager = GameManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("PP");
        if (collision.gameObject.tag == "Enemy")
        {
            gameManager.currentHealth -= 10;
            SpawnManager.Instance.worms.Remove(collision.gameObject.GetComponent<Enemy>());
            Destroy(collision.gameObject);
            if (gameManager.currentHealth <= 0)
            {
                gameManager.currentHealth = 0;
            }
        }
    }
}
