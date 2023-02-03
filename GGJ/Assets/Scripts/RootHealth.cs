using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RootHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Text healthText;

    void Start()
    {
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
        }
    }

    void UpdateHealthText()
    {
        healthText.text = "Health: " + currentHealth;
    }
}
