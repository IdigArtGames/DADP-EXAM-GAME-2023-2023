using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    private Vector3 startPosition; // Initial position of the puzzle piece
    private bool isCorrectPosition; // Flag to check if the piece is in the correct position

    private void Start()
    {
        startPosition = transform.position;
    }

    public void SetCorrectPosition(Vector3 position)
    {
        startPosition = position;
    }

    public void CheckCorrectPosition()
    {
        float distance = Vector3.Distance(transform.position, startPosition);
        isCorrectPosition = distance < 1f; // You can adjust this threshold based on your needs
    }

    public bool IsInCorrectPosition()
    {
        return isCorrectPosition;
    }
}
