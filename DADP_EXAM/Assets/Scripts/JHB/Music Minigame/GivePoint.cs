using UnityEngine;
using UnityEngine.EventSystems;

public class GivePoint : MonoBehaviour, IPointerDownHandler
{
    MusicMinigameManager music;

    void Awake()
    {
         music = FindObjectOfType<MusicMinigameManager>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        music.score++;
        Destroy(gameObject);
    }
}
