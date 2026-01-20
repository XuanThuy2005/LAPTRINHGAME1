using UnityEngine;
using TMPro;

public class UIAngleDisplay : MonoBehaviour
{
    public SignedAngleRotator rotator;
    public TextMeshProUGUI angleText;

    void Update()
    {
        angleText.text = "Angle: " + rotator.currentAngle.ToString("F1");
    }
}
