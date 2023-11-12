using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    [Header("Sliders")]
    [SerializeField] private Slider musicVolumeSlider;
    [SerializeField] private Slider soundEffectsSlider;

    [Header("AudioSources")]
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
        musicVolumeSlider.value = musicVolume;

        soundEffectsAudioSource.volume = soundEffectsVolume;
        soundEffectsSlider.value = soundEffectsVolume;
    }

    void Update()
    {
        musicVolume = musicVolumeSlider.value;
        musicAudioSource.volume = musicVolume;

        soundEffectsVolume = soundEffectsSlider.value;
        soundEffectsAudioSource.volume = soundEffectsVolume;

        PlayerPrefs.SetFloat("musicPlaylistVolume", musicVolume);
        PlayerPrefs.SetFloat("soundEffectsVolume", soundEffectsVolume);
    }
}
