using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFog : MonoBehaviour
{
    void Start()
    {
        RenderSettings.fog = true;
        RenderSettings.fogMode = FogMode.Exponential;
        RenderSettings.fogColor = Color.gray;
        RenderSettings.fogDensity = 0.05f;
    }
}

