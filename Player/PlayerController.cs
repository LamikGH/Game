using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float x;
    private float y;
    private float z;

    public CharacterController controller;

    public float speed;

    private float jumpheight = 0.8f;
    private float gravity = -9.81f;
    Vector3 velocity;

    public Transform chekerGround;
    public float groundDistance;
    private int groundMask;

    void Start()
    {
        speed = 10f;
        groundDistance = 0.58f;
        groundMask = LayerMask.GetMask("Ground");
    }


    void Update()
    {
        ControllerPlayer();
        JumpAndGravity();

    }

    public void ControllerPlayer()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }

    public void JumpAndGravity()
    {
        velocity.y += gravity * Time.deltaTime;
        if (isGround() && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2f * gravity);
        }
        controller.Move(velocity * Time.deltaTime);
    }

    public bool isGround()
    {
        return Physics.CheckSphere(chekerGround.position, groundDistance, groundMask);
    }

    private IEnumerator CursorLock()
    {
        Cursor.lockState = CursorLockMode.None;
        yield return new WaitForSeconds(0.01f);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
