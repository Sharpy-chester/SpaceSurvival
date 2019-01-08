using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float moveVelocityX = 0f;
    public float moveVelocityZ = 0f;
    public bool allowMovement = true;
    public GameManager gameManager;

    public float maxSpeed = 6f;

    void Awake()
    {

    }

    void Update()
    {
        allowMovement = gameManager.allowMovement;
        if (allowMovement)
        {


            if (Input.GetKey(KeyCode.A))
            {
                if (moveVelocityX > 0)
                {
                    moveVelocityX -= (moveSpeed * 3) * Time.deltaTime;
                }
                else
                {
                    moveVelocityX -= moveSpeed * Time.deltaTime;
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                if (moveVelocityX > 0)
                {
                    moveVelocityX += (moveSpeed * 3) * Time.deltaTime;
                }
                else
                {
                    moveVelocityX += moveSpeed * Time.deltaTime;
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                if (moveVelocityZ > 0)
                {
                    moveVelocityZ -= (moveSpeed * 3) * Time.deltaTime;
                }
                else
                {
                    moveVelocityZ -= moveSpeed * Time.deltaTime;
                }
            }
            if (Input.GetKey(KeyCode.W))
            {
                if (moveVelocityZ > 0)
                {
                    moveVelocityZ += (moveSpeed * 3) * Time.deltaTime;
                }
                else
                {
                    moveVelocityZ += moveSpeed * Time.deltaTime;
                }
            }
            moveVelocityX = Mathf.Clamp(moveVelocityX, -maxSpeed, maxSpeed);
            moveVelocityZ = Mathf.Clamp(moveVelocityZ, -maxSpeed, maxSpeed);
            transform.position += new Vector3(moveVelocityX * Time.deltaTime, 0, moveVelocityZ * Time.deltaTime);


            if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
                moveVelocityX -= (moveVelocityX * 10) * Time.deltaTime;
            }
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            {
                moveVelocityZ -= (moveVelocityZ * 10) * Time.deltaTime;
            }


        }
    }
}
