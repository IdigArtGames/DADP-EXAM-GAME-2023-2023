using UnityEngine;
using TMPro;

public class MusicManager : MonoBehaviour
{
    public MusicSO musicSO;
    public TMP_Text lineSpace;
    private int index = 0;

    //GameObjects
    public GameObject okButton;
    public GameObject NextButton;

    private void Start()
    {
        lineSpace.text = musicSO.lines[index];
    }
    void Update()
    {
        lineSpace.text = musicSO.lines[index];

        if (index >= musicSO.lines.Length-1)
        {
            okButton.SetActive(true);
            NextButton.SetActive(false);
        }
    }

    public void NextLine()
    {
        if(index < musicSO.lines.Length-1)
        {
            index++;
        }
    }
}
