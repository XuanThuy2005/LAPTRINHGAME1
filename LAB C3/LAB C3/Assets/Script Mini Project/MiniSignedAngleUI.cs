using UnityEngine;
using TMPro;

public class MiniSignedAngleUI : MonoBehaviour
{
    public Transform turret;
    public Transform player;
    public TextMeshProUGUI angleText;

    void Update()
    {
        if (!turret || !player) return;

        // Vector từ turret -> player
        Vector2 dir = player.position - turret.position;

        // Hướng hiện tại của turret
        Vector2 forward = turret.right;

        // Góc lệch SignedAngle (đúng bài Lab 4)
        float signedAngle = Vector2.SignedAngle(forward, dir);

        // Hiển thị 1 dòng gọn
        angleText.text = "Angle: " + signedAngle.ToString("F1") + "°";
    }
}
