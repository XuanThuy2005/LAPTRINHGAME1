using UnityEngine;
using TMPro;

public class MiniUIHealth : MonoBehaviour
{
    public TextMeshProUGUI hpText;

    public void UpdateUI(int hp)
    {
        hpText.text = "HP: " + hp;
    }

    public void ShowGameOver()
    {
        hpText.text = "GAME OVER";
    }
}
