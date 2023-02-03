using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    Enemy enemy;

    private void Update()
    {
            //source.PlayOneShot(clip);
    }

}