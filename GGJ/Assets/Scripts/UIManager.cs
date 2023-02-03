using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Animator shopAnim;

    public void ToggleOpenShop()
    {
        if (shopAnim.GetBool("Open"))
        {
            shopAnim.SetBool("Open", false);
        }
        else
        {
            shopAnim.SetBool("Open", true);
        }
    }
}
