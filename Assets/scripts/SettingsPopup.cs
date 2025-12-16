using System;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour
{
    [SerializeField] private Slider speedSlifer;
    

    public void OnSoundMute()
    {
        Managers.Audio.SoundMute = !Managers.Audio.SoundMute;
    }

    public void OnSoundValue(float value)
    {
        Managers.Audio.SoundValue = value;
    }
    
    public void Open()
    {
        gameObject.SetActive(true);
    }
    
    public void Close()
    {
        gameObject.SetActive(false);
    }
}
