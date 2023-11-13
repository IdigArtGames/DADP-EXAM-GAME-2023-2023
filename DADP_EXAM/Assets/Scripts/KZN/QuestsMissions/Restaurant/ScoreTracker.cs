using UnityEngine;
using UnityEngine.EventSystems;

public class ScoreTracker : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        ConveyerBelt conveyerBelt = FindObjectOfType<ConveyerBelt>();
        conveyerBelt.score++;
        Destroy(gameObject);
    }
}
