using UnityEngine;

public class InteractWithNPC : MonoBehaviour
{
    [SerializeField] Transform npcNeck;
    [SerializeField] Transform playerHead;

    [SerializeField] Canvas canvas;
    [SerializeField] Canvas dialogueCanvas;

    void Update()
    {
        float interactRange = 1.5f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);

        bool isPlayerInRange = false;
        foreach (var collider in colliders)
        {
            Npc npc = collider.GetComponent<Npc>();
            if (npc != null) 
            {
                isPlayerInRange = true;
                float lerpSmooth = .01f;
                Vector3 newPlayer = Vector3.Lerp(npcNeck.position, playerHead.position, lerpSmooth);
                npcNeck.LookAt(newPlayer);

                //canvas
                canvas.gameObject.SetActive(false);
                dialogueCanvas.gameObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    npc.Interact();
                }      
            }

            else if(!isPlayerInRange)
            {
                npcNeck.rotation = Quaternion.identity;

                canvas.gameObject.SetActive(true);
                dialogueCanvas.gameObject.SetActive(false);
            }
        } 
    }
}
