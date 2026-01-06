using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour
{
    [SerializeField] private AudioClip sound;
    [SerializeField] private TMP_Text textSansivityValue;
    
    [SerializeField] private List<MouseLook> mouseLooks;


    private void Start()
    {
        textSansivityValue.text = "5";
    }

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
        Cursor.visible = false;
        gameObject.SetActive(false);
    }

    public void OnSensivityValue(float value)
    {
        foreach (var mouseLook in mouseLooks)
        {
            mouseLook.EditSensivity(value);
            textSansivityValue.text = value.ToString("0.0");
        }
    }
}
