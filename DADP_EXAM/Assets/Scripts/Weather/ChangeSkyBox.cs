using UnityEngine;

public class ChangeSkyBox : MonoBehaviour
{
    public Material[] skybox;
    int index;



    void Start()
    {
        int Rand = Random.Range(0, skybox.Length);
        RenderSettings.skybox = skybox[index];
    }
}
