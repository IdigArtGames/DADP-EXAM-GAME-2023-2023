using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "GhostDialogue", menuName = "Ghost/GhostLines")]
public class GhostDialogueSO : ScriptableObject
{
    public string[] lines;
}
