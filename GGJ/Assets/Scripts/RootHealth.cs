using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RootHealth : MonoBehaviour
{
    GameManager gameManager;
    public int maxHealth = 100;
    public int currentHealth;
    public Text healthText;

    void Start()
    {
        gameManager = GameManager.instance;
        currentHealth = maxHealth;
        UpdateHealthText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            Debug.Log("PP");
        if (collision.gameObject.tag == "Enemy")
        {
            currentHealth -= 10;
            UpdateHealthText();
            WormKiller.Instance.worms.Remove(collision.gameObject.GetComponent<Enemy>());
            Destroy(collision.gameObject);
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                Death();
            }
        }
    }

    void UpdateHealthText()
    {
        healthText.text = "Health: " + currentHealth;
    }

    void Death()
    {
        gameManager.Pause();
    }
}
