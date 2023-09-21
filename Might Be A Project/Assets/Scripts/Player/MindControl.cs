using System.Collections;
using UnityEngine;

public class MindControl : MonoBehaviour
{
    public AIAgent[] aiAgent;
    public float secondsPassed = 59;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q ) && secondsPassed >= 59 )
        {
            foreach (AIAgent agent in aiAgent)
            {
                agent.enabled = false;
                StartCoroutine(ActivateThem());
                print("Is working");
                secondsPassed = 0;
            }
        }
        secondsPassed += Time.deltaTime;
    }

    IEnumerator ActivateThem()
    {
        yield return new WaitForSeconds(10);
        foreach (AIAgent agent in aiAgent)
        {
            agent.enabled = true;
        }
    }
}