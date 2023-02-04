using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squashAnim : MonoBehaviour
{
    private void Start()
    {
        print("squash");
        Destroy(gameObject, 1);
    }
}
