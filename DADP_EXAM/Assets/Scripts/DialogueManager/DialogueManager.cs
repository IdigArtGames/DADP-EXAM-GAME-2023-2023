using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text messageTxt;
    public TMP_Text actorName;

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        DisplayDialogue();
    }

    public void DisplayDialogue()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageTxt.text = messageToDisplay.message;

        Actor actorToSpeak = currentActors[messageToDisplay.actorID];
        actorName.text = actorToSpeak.actorName;
    }
}
