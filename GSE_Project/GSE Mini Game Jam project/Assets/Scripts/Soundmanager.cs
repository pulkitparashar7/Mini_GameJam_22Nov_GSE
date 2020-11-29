using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip throw1;
    public AudioClip throw2;
    public AudioClip throw3;
    public AudioClip click1;
    public AudioClip defeat;
    public AudioClip right_patient;
    public AudioClip start_game;
    public AudioClip victory;
    public AudioClip wrong_patient;
    public AudioClip loadingscreen1;



    public void Play_throw1()
    {
        audioSource.clip = ThrowSound_1;
        audioSource.Play();
    }

    public void Play_throw2()
    {
        audioSource.clip = ThrowSound_2;
        audioSource.Play();
    }

    public void Play_throw3()
    {
        audioSource.clip = ThrowSound_3;
        audioSource.Play();
    }

    public void click1()
    {
        audioSource.clip = click1;
        audioSource.Play();
    }

    public void defeat()
    {
        audioSource.clip = defeat;
        audioSource.Play();
    }

    public void right_patient()
    {
        audioSource.clip = right_patient;
        audioSource.Play();
    }

    public void start_game()
    {
        audioSource.clip = start_game;
        audioSource.Play();
    }

    public void victory()
    {
        audioSource.clip = victory;
        audioSource.Play();
    }

    public void wrong_patient()
    {
        audioSource.clip = wrong_patient;
        audioSource.Play();
    }

    public void loadingscreen1()
    {
        audioSource.clip = loadingscreen1;
        audioSource.Play();
    }