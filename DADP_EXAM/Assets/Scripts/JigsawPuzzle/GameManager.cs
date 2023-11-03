using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PuzzlePiece[] puzzlePieces; // Reference to all puzzle pieces
    public RectTransform canvasRect; // Reference to the canvas RectTransform component

    private void Start()
    {
        ShufflePuzzlePieces();
    }

    private void ShufflePuzzlePieces()
    {
        // Get canvas dimensions
        float canvasWidth = canvasRect.rect.width;
        float canvasHeight = canvasRect.rect.height;

        // Shuffle the puzzle pieces' positions within the canvas area
        foreach (PuzzlePiece piece in puzzlePieces)
        {
            // Calculate random position within canvas boundaries
            float randomX = Random.Range(-canvasWidth / 2f, canvasWidth / 2f);
            float randomY = Random.Range(-canvasHeight / 2f, canvasHeight / 2f);

            Vector3 randomPosition = new Vector3(randomX, randomY, 0f);
            piece.transform.position = randomPosition;
            piece.SetCorrectPosition(randomPosition);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckPuzzleCompletion();
        }
    }

    private void CheckPuzzleCompletion()
    {
        // Check if all puzzle pieces are in correct positions
        bool isCompleted = true;
        foreach (PuzzlePiece piece in puzzlePieces)
        {
            piece.CheckCorrectPosition();
            if (!piece.IsInCorrectPosition())
            {
                isCompleted = false;
                break;
            }
        }

        if (isCompleted)
        {
            Debug.Log("Puzzle completed!");
        }
    }
}
