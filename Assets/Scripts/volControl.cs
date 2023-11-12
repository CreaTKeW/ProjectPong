using UnityEngine;
using UnityEngine.UI;

public class volControl : MonoBehaviour
{
    [SerializeField] private AudioSource musicAudioSource;
    [SerializeField] private AudioSource soundEffectsAudioSource;

    private float musicVolume = .5f;
    private float soundEffectsVolume = .5f;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicPlaylistVolume"))
        {
            PlayerPrefs.SetFloat("musicPlaylistVolume", musicVolume);
        }
        else musicVolume = PlayerPrefs.GetFloat("musicPlaylistVolume");

        if (!PlayerPrefs.HasKey("soundEffectsVolume"))
        {
            PlayerPrefs.SetFloat("soundEffectsVolume", soundEffectsVolume);
        }
        else soundEffectsVolume = PlayerPrefs.GetFloat("soundEffectsVolume");


        musicAudioSource.volume = musicVolume;
        soundEffectsAudioSource.volume = soundEffectsVolume;
    }

    void Update()
    {
        musicAudioSource.volume = musicVolume;
        soundEffectsAudioSource.volume = soundEffectsVolume;

        PlayerPrefs.SetFloat("musicPlaylistVolume", musicVolume);
        PlayerPrefs.SetFloat("soundEffectsVolume", soundEffectsVolume);
    }
}
