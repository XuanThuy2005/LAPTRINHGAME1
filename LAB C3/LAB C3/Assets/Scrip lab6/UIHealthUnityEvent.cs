using UnityEngine;
using TMPro;

public class UIHealthUnityEvent : MonoBehaviour
{
    public TextMeshProUGUI hpText;

      public void UpdateUI(int hp)
{
    Debug.Log("UI UPDATE CALLED: " + hp);

    if (hpText == null)
    {
        Debug.LogError("hpText IS NULL!");
        return;
    }

    hpText.text = "HP: " + hp;
}
    public void ShowGameOver()
    {
        hpText.text = "GAME OVER";
    }
 

}
