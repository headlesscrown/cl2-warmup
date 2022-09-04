using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;

    private Vector3 currentPosition;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

        Movement(); //call
    }

    public void Movement()
    {

        //if (Input.GetKey(KeyCode.W)) currentPosition.z += speed * Time.deltaTime; //enable vertical movement (u)
        //if (Input.GetKey(KeyCode.S)) currentPosition.z -= speed * Time.deltaTime; //enable vertical movement (d)
        if (Input.GetKey(KeyCode.D)) currentPosition.x += movementSpeed * Time.deltaTime; //enable lateral movement (l)
        if (Input.GetKey(KeyCode.A)) currentPosition.x -= movementSpeed * Time.deltaTime; //enable lateral movement (r)

        transform.position = currentPosition; //set to current position
    }
}
