using TMPro;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    [SerializeField] RestaurantMinigameSO minigame;
    public TMP_Text sentences;
    private int index = 0;

    // 
    public GameObject[] buttons;
    public GameObject[] allMinigame;
    // Ref to the conveyerbelt script
    ConveyerBelt belt;
    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject ready;
    public GameObject instructions;


    private void Awake()
    {
        belt = FindObjectOfType<ConveyerBelt>();
    }
    void Update()
    {
        sentences.text = minigame.instruction[index];

        if (belt.score >= 25 && belt.seconds > 0 )
        {
            winScreen.SetActive(true);
        }
        else if( belt.score <= 25 && belt.seconds <= 0  && !ready.activeSelf && !instructions.activeSelf)
        {
            loseScreen.SetActive(true);
        }
    }
    
    public void NextLine()
    {
        if(index < minigame.instruction.Length -1 )
        {
            index++;        
        }
        else
        {
            buttons[0].SetActive(false);
            buttons[1].SetActive(true);
        }
    }

    public void OkButton()
    {
        foreach(var objects in allMinigame)
        {
            objects.SetActive(true);
            belt.seconds = 60;
            belt.score = 0;
        }
    }

    public void RestartMinigame()
    {
        OkButton();
    }
}
