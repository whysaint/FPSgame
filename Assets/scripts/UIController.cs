using System;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;

    private int score;

    void OnEnable()
    {
        Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void OnDisable()
    {
        Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void Start()
    {
        score = 0;
        scoreLabel.text = score.ToString();
        
        settingsPopup.Close();
    }
    
    void OnEnemyHit()
    {
        score += 1;
        scoreLabel.text = score.ToString();
    }

    public void OnOpenSettings()
    {
        settingsPopup.Open();
    }
}
