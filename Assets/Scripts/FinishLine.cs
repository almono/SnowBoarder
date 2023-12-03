using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public ParticleSystem finishParticles;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            finishParticles.Play();
            GetComponent<AudioSource>().Play();
            Invoke("RestartLevel", 1f);
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
