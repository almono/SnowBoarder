using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerBody;
    private SurfaceEffector2D surfaceEffector;
    [SerializeField] protected float rotationPower = 10.0f, boostSpeed = 30.0f;
    private float baseSpeed = 10f;
    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerBody.AddTorque(rotationPower);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerBody.AddTorque(-rotationPower);
        }
    }

    void RespondToBoost()
    {
        // if we push up then boost
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = boostSpeed;
        }
        else
        {
            surfaceEffector.speed = baseSpeed;         
        }
    }
}
