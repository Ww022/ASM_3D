using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------------Audio Sources---------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------------Audio Clip---------------")]
    public AudioClip background;
    public AudioClip shoot;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
