using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Sources")]
    public AudioSource musicSource;
    public AudioSource sfxSource;

    [Header("Audio Clips")]
    public Sound[] sounds;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void PlayMusic(string name)
    {
        Sound s = FindSound(name);
        if (s != null)
        {
            musicSource.clip = s.clip;
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = FindSound(name);
        if (s != null)
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void SetMusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SetSFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }

    private Sound FindSound(string name)
    {
        foreach (Sound s in sounds)
        {
            if (s.name == name)
                return s;
        }

        Debug.LogWarning("Sonido no encontrado: " + name);
        return null;
    }
}

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
}

