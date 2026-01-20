using UnityEngine;

public class MiniGameOver : MonoBehaviour
{
    public void OnGameOver()
    {
        Debug.Log("GAME OVER");
        Time.timeScale = 0f;
    }
}
