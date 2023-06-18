using UnityEngine;

public class volControl : MonoBehaviour
{
    public AudioSource audioSource;

    private const string VolumeKey = "volume";
    private float musicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("volume");
        audioSource.volume = musicVolume;
    }

    void Update()
    {
        audioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    void OnVolumeChanged(float volume)
    {
        musicVolume = volume;
    }
}
