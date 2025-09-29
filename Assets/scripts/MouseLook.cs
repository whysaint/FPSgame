using System;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseYAndX = 0,
        MouseY = 1,
        MouseX = 2
    }

    public RotationAxes axes = RotationAxes.MouseYAndX;

    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;
    
    public float minimunVert = -45.0f;
    public float maximumVert = 45.0f;
    
    public float verticalRot = 0f;

    private void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
        {
            body.freezeRotation = true;
        }
    }

    private void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }else if (axes == RotationAxes.MouseY)
        {
            verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
            verticalRot = Mathf.Clamp(verticalRot, minimunVert, maximumVert);

            float horizontalRot = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(verticalRot, horizontalRot, 0);
        }else if (axes == RotationAxes.MouseYAndX)
        {
            verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
            verticalRot = Mathf.Clamp(verticalRot, minimunVert, maximumVert);

            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float horizontalRot = transform.localEulerAngles.y + delta;

            transform.localEulerAngles = new Vector3(verticalRot, horizontalRot, 0);
        }
    }
}
