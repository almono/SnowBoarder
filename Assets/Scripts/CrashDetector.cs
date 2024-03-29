using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    public ParticleSystem crashParticles;
    public AudioClip crashEffect;

    private bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground") && !hasCrashed)
        {
            hasCrashed = true;
            crashParticles.Play();
            GetComponent<AudioSource>().PlayOneShot(crashEffect);
            FindObjectOfType<PlayerController>().DisableControls();
            Invoke("RestartLevel", 1f);
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
