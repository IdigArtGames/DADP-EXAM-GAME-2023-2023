using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public Text messageText;

    // Function called when the UI button is clicked
    public void OnButtonClick()
    {
        
        slider.value = Mathf.Clamp(slider.value + 1, 0, 5);

        
        messageText.gameObject.SetActive(true);

        
        Invoke("HideMessageText", 3f);
    }

    
    void HideMessageText()
    {
        messageText.gameObject.SetActive(false);
    }
}
