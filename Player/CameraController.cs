using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float xMouse;
    private float yMouse;

    public float xRot = 0f;

    public Transform player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        CameraControl();
    }

    public void CameraControl()
    {
        xMouse = Input.GetAxis("Mouse X");
        yMouse = Input.GetAxis("Mouse Y");

        xRot -= yMouse;
        xRot = Mathf.Clamp(xRot, -75f, 75f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);

        player.Rotate(Vector3.up * xMouse);
    } 
}
