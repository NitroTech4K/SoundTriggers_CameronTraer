using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnter : MonoBehaviour
{   
     public AudioSource Speaker;


    private void OnTriggerEnter(Collider other)
    {
       Speaker.Pause();
        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Speaker.Play();
        Debug.Log(other.gameObject.name);
    }

}
