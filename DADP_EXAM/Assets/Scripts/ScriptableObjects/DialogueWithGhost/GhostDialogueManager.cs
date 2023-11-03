using UnityEngine;
using TMPro;

public class GhostDialogueManager : MonoBehaviour
{
    public TMP_Text line;
    private int index = 0;
    [SerializeField] GhostDialogueSO ghostLines;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject okButton;
    void Update()
    {
        line.text = ghostLines.lines[index];           
    }

    public void NextLine()
    {
        if (index < ghostLines.lines.Length - 1)
        {
            index++;
        }
        else
        {
            print("No lines!!");
            nextButton.SetActive(false);
            okButton.SetActive(true);
        }
    }
}
