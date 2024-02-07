using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class clickable : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private UnityEvent _click_event;

    public void OnPointerClick (PointerEventData eventData)
    {
        _click_event.Invoke();
    }
}
