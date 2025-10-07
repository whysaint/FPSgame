using System;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;

    private void Update()
    {
        transform.Translate(0,0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = GetComponent<PlayerCharacter>();
        if (player != null)
        {
            Debug.Log("Player hit");
        }
        Destroy(gameObject);
    }
}
