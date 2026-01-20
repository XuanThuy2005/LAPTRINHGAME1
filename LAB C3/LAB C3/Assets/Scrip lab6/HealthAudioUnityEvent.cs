using UnityEngine;

public class HealthAudioUnityEvent : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlayHitSound(int hp)
    {
        audioSource.Play();
    }

    public void PlayDeathSound()
    {
        audioSource.Play();
    }
}
