using System;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int Health;

    private void Start()
    {
        Health = 5;
    }

    public void Hurt(int damage)
    {
        Health -= damage;
        Debug.Log($"- 1hp, lost {Health}hp");
    }
}
