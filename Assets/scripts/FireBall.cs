using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
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
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            Debug.Log("Player hit");
            player.Hurt(damage);
        }
        Destroy(gameObject);
    }
}
