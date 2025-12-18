using System;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour
{
    [SerializeField] private AudioClip sound;

    public void OnSoundToggle()
    {
        Managers.Audio.SoundMute = !Managers.Audio.SoundMute;
        Managers.Audio.PlaySound(sound);
    }
    
    public void OnSoundMute()
    {
        Managers.Audio.SoundMute = !Managers.Audio.SoundMute;
    }

    public void OnSoundValue(float value)
    {
        Managers.Audio.SoundValue = value;
    }

    public void OnClose()
    {
        gameObject.SetActive(false);
    }
}
