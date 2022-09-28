using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip Clip1;
    public AudioClip Clip2;
    public AudioClip Clip3;

    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();

        StartCoroutine(playEngineSound());
    }

    IEnumerator playEngineSound()
    {
        audio.clip = Clip1;
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        audio.clip = Clip2;
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        audio.clip = Clip3;
        audio.Play();
        StartCoroutine(playEngineSound());
    }
}
