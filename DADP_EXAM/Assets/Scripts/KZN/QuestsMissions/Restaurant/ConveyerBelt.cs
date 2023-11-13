using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConveyerBelt : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] item;
    float timer = 0f;

    //score
    public TMP_Text scoreTxt;
    public float score = 0;
    private float maxScore = 25;

    //timer
    public TMP_Text timerTxt;
    public int minutes;
    public float seconds = 60;

    public Image progressFill;

    private MinigameManager minigameManager;

    public GameObject[] turnThemOff;

    private void Awake()
    {
        minigameManager =FindObjectOfType<MinigameManager>();
    }

    void Update()
    {
        scoreTxt.text = score.ToString();
        timer += Time.deltaTime;
        int randNumber = Random.Range(2, 5);

        foreach(var objects in minigameManager.allMinigame)
        {
            if(objects.activeSelf)
            {
                if (timer >= randNumber)
                {
                    SpawnItem();
                    timer = 0;
                }
                //timer
                DisplayTmer();
                break;
            }
        }

        //Bunny Chow Progress
        progressFill.fillAmount = score / maxScore;

        if (score >= 25 && seconds > 0)
        {
            foreach (var objects in turnThemOff)
            {
                if(objects.activeSelf)
                {
                    objects.SetActive(false);
                }
            }
        }
        else if(score <= 25 && seconds <= 0)
        {
            foreach (var objects in turnThemOff)
            {
                if (objects.activeSelf)
                {
                    objects.SetActive(false);
                }
            }
        }
    }

    void DisplayTmer()
    {
        seconds -= Time.deltaTime;
        if(seconds<= 0)
        {
            seconds = 0;
            //minutes--;
        }
        timerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    void SpawnItem()
    {
        int randPoint = Random.Range(0, spawnPoint.Length);
        int randItem = Random.Range(0, item.Length);
        GameObject beltItem = Instantiate(item[randItem], spawnPoint[randPoint].position, spawnPoint[randPoint].rotation) as GameObject;
        beltItem.transform.SetParent(spawnPoint[randPoint].transform);
    }

    public void OffToJHB()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
