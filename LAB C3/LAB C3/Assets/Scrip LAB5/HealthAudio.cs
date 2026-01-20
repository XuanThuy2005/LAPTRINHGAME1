using UnityEngine;

public class HealthAudio : MonoBehaviour
{
    public PlayerHealth player;
    public AudioSource audioSource;

    void OnEnable()
    {
        player.OnHealthChanged += PlayHitSound;
        player.OnDead += PlayDeathSound;
    }

    void OnDisable()
    {
        player.OnHealthChanged -= PlayHitSound;
        player.OnDead -= PlayDeathSound;
    }

    void PlayHitSound(int hp)
    {
        audioSource.Play();
    }

    void PlayDeathSound()
    {
        audioSource.Play();
    }
}
