using UnityEngine;

public class CustomCursor : MonoBehaviour
{

    public Texture2D cursorArt;

    void Awake()
    {
        SetCursor();
    }

    void SetCursor()
    {
        Cursor.SetCursor(cursorArt, Vector2.zero, CursorMode.Auto);
    }
}
