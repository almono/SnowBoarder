using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerBody;
    [SerializeField] protected float rotationPower = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) 
        { 
            playerBody.AddTorque(rotationPower);
        } else if(Input.GetKey(KeyCode.RightArrow))
        {
            playerBody.AddTorque(-rotationPower);
        }
    }
}
