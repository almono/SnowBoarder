using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    public ParticleSystem crashParticles;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            crashParticles.Play();
            Invoke("RestartLevel", 1f);
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
