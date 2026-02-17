using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    [System.Serializable]
    public class EnvironmentPreset
    {
        public Material skybox;
        public Color lightColor = Color.white;
        public float lightIntensity = 1f;
    }

    public Light directionalLight;
    public AudioSource musicSource;
    public EnvironmentPreset[] presets;

    public void ApplyEnvironment(int index)
    {
        if (index < 0 || index >= presets.Length) return;

        // Skybox
        RenderSettings.skybox = presets[index].skybox;
        DynamicGI.UpdateEnvironment();

        // Luz
        directionalLight.color = presets[index].lightColor;
        directionalLight.intensity = presets[index].lightIntensity;
    }
}

