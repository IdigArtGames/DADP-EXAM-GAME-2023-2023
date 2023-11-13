using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MusicMinigameManager : MonoBehaviour
{
    public GameObject[] musicalNotes;
    public Transform[] spawnPoints;
    public Color[] noteColor;
    float afterThis = 0;

    //Time
    private float seconds = 60;
    private float minutes = 0;
    public Image timerFill;
    public TMP_Text timerTxt;

    //points
    public float score = 0;
    private float maxScore = 25;
    public TMP_Text pointTxt;
    public Image progressFill;

    //win && lose
    public GameObject winScreen;
    public GameObject loseScreen;

    //clip
    public GameObject clip;

    public GameObject theGame;
    public GameObject instructions;

    void Start()
    {
        score = 0;
        seconds = 60;
    }

    void Update()
    {
        afterThis += Time.deltaTime;

        if(afterThis >= 2f && theGame.activeSelf )
        {
            SpawnNotes();
            afterThis = 0;
        }

        pointTxt.text = score.ToString();

        if(theGame.activeSelf )
        {
            CountDownTimer();
        }

        //if(seconds<=0)
        //{
        //    theGame.SetActive(false);
        //}
        progressFill.fillAmount = score / maxScore;


        if(score >= maxScore && seconds> 0 && !instructions.activeSelf )
        {
            winScreen.gameObject.SetActive(true);
        }
        else if(score <= maxScore && seconds <= 0 && !instructions.activeSelf )
        {
            loseScreen.gameObject.SetActive(true);
        }

        if(winScreen.gameObject.activeSelf || loseScreen.gameObject.activeSelf)
        {
            theGame.SetActive(false);
            clip.SetActive(false);
        }
    }

    private void SpawnNotes()
    {

        int randPoint = Random.Range(0, spawnPoints.Length);
        int randNote = Random.Range(0, musicalNotes.Length);
        int randColor = Random.Range(0, noteColor.Length);

        GameObject notes = Instantiate(musicalNotes[randNote], spawnPoints[randPoint].position, spawnPoints[randPoint].rotation) as GameObject;
        Image notesColor = notes.GetComponent<Image>();

        if(notesColor != null )
        {
            notesColor.color = noteColor[randColor];
        }
        else
        {
            print("No notes");
        }

        notes.transform.SetParent(spawnPoints[randPoint].transform);
    }

    void CountDownTimer()
    {
        seconds-= Time.deltaTime;
        if(seconds <= 0 )
        {
            seconds = 0;
            minutes = 0;
        }

        timerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        timerFill.fillAmount = seconds / 60f;
    }

    public void TryAgain()
    {
        seconds = 60;
        score = 0;
        afterThis = 0;
    }
}
