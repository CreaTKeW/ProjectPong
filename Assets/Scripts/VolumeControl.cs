using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    private const string VolumeKey = "volume";
    private float musicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("volume");
        audioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;
    }

    void Update()
    {
       musicVolume = volumeSlider.value;
       audioSource.volume = musicVolume;
       PlayerPrefs.SetFloat("volume", musicVolume);      
    }

    void OnVolumeChanged(float volume)
    {
        musicVolume = volume;
    }
}
