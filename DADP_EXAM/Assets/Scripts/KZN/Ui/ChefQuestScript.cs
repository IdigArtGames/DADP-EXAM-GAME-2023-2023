using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChefQuestScript : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] item;

    //timer
    public TMP_Text timerTxt;
    public int minutes = 0;
    private float seconds = 60;
    public Image fillImage;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void DisplayTimer()
    {
        seconds -= Time.deltaTime;
        fillImage.fillAmount = seconds / 60;
        if (seconds <= 0)
        {
            seconds = 60;
            minutes--;
        }
        timerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public void SpawnItem()
    {
        int randPoint = Random.Range(0, spawnPoint.Length);
        int randItem = Random.Range(0, item.Length);
        print("Yay");
        GameObject beltItem = Instantiate(item[randItem], spawnPoint[randPoint].position, spawnPoint[randPoint].rotation) as GameObject;
        beltItem.transform.SetParent(spawnPoint[randPoint].transform);
    }
}
