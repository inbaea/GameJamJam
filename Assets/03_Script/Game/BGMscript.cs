using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMscript : MonoBehaviour
{
    public AudioClip[] intro_music;
    AudioSource soundSource;
    int a;

    void Start()
    {
        soundSource = GetComponent<AudioSource>();
        StartCoroutine("Playlist");
    }

    void Update()
    {
        if (!soundSource.isPlaying)
        {
            a = Random.Range(0, 4);
            soundSource.clip = intro_music[a];
            soundSource.Play();
        }
    }

    IEnumerator Playlist()
    {
        a = Random.Range(0, 4);
        soundSource.clip = intro_music[a];
        soundSource.Play();

        yield return null;
    }
}
