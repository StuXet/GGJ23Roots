using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDestroy : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject == gameObject)
                {
                    gameObject.GetComponent<Enemy>().health -= GameManager.instance.playerDamage;
                }
            }
        }
    }
}