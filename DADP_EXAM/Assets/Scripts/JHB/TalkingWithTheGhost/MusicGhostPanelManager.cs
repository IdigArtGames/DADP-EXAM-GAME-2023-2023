using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MusicGhostPanelManager : MonoBehaviour
{
    public MusicGhostPanelSO music;
    public TMP_Text lineTxt;
    public Image ghostIcon;

    public GameObject nextButton;
    public GameObject OkButton;
    private int index = 0;
    void Start()
    {
        ghostIcon.sprite = music.ghostIcon;
    }

    void Update()
    {
        lineTxt.text = music.lines[index];
        if(index >= music.lines.Length -1)
        {
            OkButton.SetActive(true);
            nextButton.SetActive(false);
        }
    }

    public void NextLine()
    {
        if(index <= music.lines.Length - 1)
        {
            index++;
        }
    }
}
