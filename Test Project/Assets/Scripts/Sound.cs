using System;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Sound : MonoBehaviour
{
    [SerializeField] private AudioClipSettings[] _clips;

    private AudioSource _audioSource;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound() 
    {
        AudioClipSettings clip = _clips[UnityEngine.Random.Range(0, _clips.Length)];

        _audioSource.volume = clip.Volume;
        _audioSource.pitch = clip.Pitch;

        _audioSource.PlayOneShot(clip.Clip);
    }
}

[Serializable]
public class AudioClipSettings
{
    [SerializeField] private AudioClip _clip;
    [SerializeField] private float _minVolume, _maxVolume = 1f;
    [SerializeField] private float _minPitch, _maxPitch = 1f;

    public AudioClip Clip => _clip;
    public float Volume => UnityEngine.Random.Range(_minVolume, _maxVolume);
    public float Pitch => UnityEngine.Random.Range(_minPitch, _maxPitch);
}