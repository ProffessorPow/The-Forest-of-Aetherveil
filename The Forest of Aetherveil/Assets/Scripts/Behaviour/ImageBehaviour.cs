using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    public Image sprite;
    public UnityEvent startEvent;

    private void Start()
    {
        sprite = GetComponent<Image>();
        startEvent.Invoke();
    }

    public void UpdateImage(FloatData obj)
    {
        sprite.fillAmount = obj.value;
    }
}