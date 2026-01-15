using UnityEngine;
using UnityEngine.EventSystems;
using PinePie.SimpleJoystick;

public class VirtualJoystick : MonoBehaviour,
    IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public RectTransform background;
    public RectTransform handle;
    public Vector2 inputVector;

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            background, eventData.position, eventData.pressEventCamera, out pos);

        pos.x /= (background.sizeDelta.x / 2);
        pos.y /= (background.sizeDelta.y / 2);

        inputVector = new Vector2(pos.x, pos.y);
        inputVector = Vector2.ClampMagnitude(inputVector, 1f);

        handle.anchoredPosition = new Vector2(
            inputVector.x * (background.sizeDelta.x / 2),
            inputVector.y * (background.sizeDelta.y / 2)
        );
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        inputVector = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;
    }
}
