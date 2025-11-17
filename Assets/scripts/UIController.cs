using System;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;

    private void Start()
    {
        settingsPopup.Close();
    }

    public void OnOpenSettings()
    {
        settingsPopup.Open();
    }
    
    public void OnPointerDown()
    {
        Debug.Log("idi nahui");
    }
}
