using UnityEngine;

public class GameOverUnityEvent : MonoBehaviour
{
    public void OnGameOver()
    {
        Debug.Log("GAME OVER (UnityEvent)");
        Time.timeScale = 0f;
    }
}
