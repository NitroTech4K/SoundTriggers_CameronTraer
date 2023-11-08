using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAndPause : MonoBehaviour
{
    public AudioSource Speaker;

    private void OnTriggerEnter(Collider other)
    {
        Speaker.Play();
        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Speaker.Stop();
        Debug.Log(other.gameObject.name);
    }
}
