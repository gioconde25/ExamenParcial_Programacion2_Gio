using UnityEngine;

public class WeatherVisualController : MonoBehaviour
{
    [Header("Skyboxes")]
    public Material clearSkybox;
    public Material cloudySkybox;
    public Material rainSkybox;
    public Material stormSkybox;
    public Material snowSkybox;

    [Header("Light")]
    public Light directionalLight;

    [Header("Post Processing")]
    public UnityEngine.Rendering.Volume postProcessVolume;

    public void ApplyWeather(string weather)
    {
        switch (weather)
        {
            case "Clear":
                SetClear();
                break;

            case "Clouds":
                SetCloudy();
                break;

            case "Rain":
            case "Drizzle":
                SetRain();
                break;

            case "Thunderstorm":
                SetStorm();
                break;

            case "Snow":
                SetSnow();
                break;

            default:
                SetClear();
                break;
        }
    }

    void SetClear()
    {
        RenderSettings.skybox = clearSkybox;
        directionalLight.intensity = 1.2f;
    }

    void SetCloudy()
    {
        RenderSettings.skybox = cloudySkybox;
        directionalLight.intensity = 0.7f;
    }

    void SetRain()
    {
        RenderSettings.skybox = rainSkybox;
        directionalLight.intensity = 0.5f;
    }

    void SetStorm()
    {
        RenderSettings.skybox = stormSkybox;
        directionalLight.intensity = 0.3f;
    }

    void SetSnow()
    {
        RenderSettings.skybox = snowSkybox;
        directionalLight.intensity = 0.9f;
    }
}
