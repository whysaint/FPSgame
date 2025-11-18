using System;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Gavno/Zalupa")]
public class FPSInput : MonoBehaviour
{
    public float speed = 6f;
    public float baseSpeed = 6.0f;
    public float gravity = -9.8f;

    public CharacterController CharacterController;

    private void OnEnable()
    {
        Messenger<float>.AddListener(GameEvent.SPEED_CHANGER, OnSpeedChanged);
    }

    private void OnDisable()
    {
        Messenger<float>.RemoveListener(GameEvent.SPEED_CHANGER, OnSpeedChanged);
    }

    private void Start()
    {
        CharacterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float DeltaX = Input.GetAxis("Horizontal") * speed;
        float DeltaY = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(DeltaX, 0f, DeltaY);
        
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;

        movement = transform.TransformDirection(movement);
        CharacterController.Move(movement);
    }

    private void OnSpeedChanged(float value)
    {
        speed = baseSpeed * value;
    }
    
}
