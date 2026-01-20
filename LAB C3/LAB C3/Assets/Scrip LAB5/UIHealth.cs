using UnityEngine;
using TMPro;

public class UIHealth : MonoBehaviour
{
    public PlayerHealth player;
    public TextMeshProUGUI hpText;

    void OnEnable()
    {
        player.OnHealthChanged += UpdateUI;
        player.OnDead += ShowGameOver;
    }

    void OnDisable()
    {
        player.OnHealthChanged -= UpdateUI;
        player.OnDead -= ShowGameOver;
    }

    void UpdateUI(int hp)
    {
        hpText.text = "HP: " + hp;
    }

    void ShowGameOver()
    {
        hpText.text = "GAME OVER";
    }
}
