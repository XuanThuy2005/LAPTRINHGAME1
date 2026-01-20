using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    public PlayerHealth player;

    void OnEnable()
    {
        player.OnDead += OnGameOver;
    }

    void OnDisable()
    {
        player.OnDead -= OnGameOver;
    }

    void OnGameOver()
    {
        Debug.Log("GAME OVER EVENT TRIGGERED");
        Time.timeScale = 0f;
    }
}
