using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource Speaker;

    private void OnTriggerEnter(Collider other)
    {
        Speaker.Play();
        Debug.Log(other.gameObject.name);
    }
}
