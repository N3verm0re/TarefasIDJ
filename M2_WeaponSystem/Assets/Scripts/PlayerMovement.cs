using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController playerController;
    public float speed = 12f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public float jumpForce = 5f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Movement input
        Vector3 move = transform.right * x + transform.forward * z;
        playerController.Move(move * speed * Time.deltaTime);

        //Gravity control
        velocity.y += gravity * Time.deltaTime;
        playerController.Move(velocity * speed * Time.deltaTime);

        if (playerController.isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        if (Input.GetButtonDown("Jump") && playerController.isGrounded)
        {
            velocity.y = jumpForce;
        }
    }
}
