using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] Button turnOff;
    [SerializeField] Button turnOn;


    private void Start()
    {
        turnOff.image.enabled = false;
    }
    public void TurnOff()
    {
        turnOff.image.enabled = true;
        turnOn.image.enabled = false;
        music.Stop();
    }

    public void TurnOn()
    {
        turnOn.image.enabled = true;
        turnOff.image.enabled = false;
        music.Play();
    }



}
