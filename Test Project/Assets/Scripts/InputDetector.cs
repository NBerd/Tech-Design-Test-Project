using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class InputDetector : MonoBehaviour
{
    [SerializeField] private UnityEvent OnMouseDownEvent;
    [SerializeField] private UnityEvent OnMouseUpEvent;

    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");

        OnMouseDownEvent?.Invoke();
    }

    private void OnMouseUp()
    {
        Debug.Log("Mouse Up");

        OnMouseUpEvent?.Invoke();
    }
}