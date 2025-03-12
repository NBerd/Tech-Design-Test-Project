using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Sound : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private float _minVolume = 1f;
    [SerializeField] private float _maxVolume = 1f;
    [SerializeField] private float _minPitch = 1f;
    [SerializeField] private float _maxPitch = 1f;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        AudioSourceSettings settings = GenerateSettings();

        _audioSource.volume = settings.Volume;
        _audioSource.pitch = settings.Pitch;

        _audioSource.PlayOneShot(_audioClip);
    }

    private AudioSourceSettings GenerateSettings() 
    {
        float volume = Random.Range(_minVolume, _maxVolume);
        float pitch = Random.Range(_minPitch, _maxPitch);

        return new AudioSourceSettings(volume, pitch);
    }
}

public struct AudioSourceSettings 
{
    public float Volume;
    public float Pitch;

    public AudioSourceSettings(float volume, float pitch) 
    {
        Volume = volume;
        Pitch = pitch;
    }
}