using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlane : MonoBehaviour
{

    //Varibles
    public float speed = 250.0f;
    public float up;

    public float forwadInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        // get the user's vertical input
        //verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);



        //Get Input
        forwadInput = Input.GetAxis("Vertical");
        up = Input.GetAxis("Horizontal");

        //Move plane
        transform.Translate(Vector3.forward * speed * Time.deltaTime);        //forward
        //transform.Translate(Vector3.up * speed_up * Time.deltaTime * up * horizontalInput);  //up
        //
        transform.Rotate(Vector3.right, Time.deltaTime * speed * up);

          
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Destroy(gameObject);
        }
    }

}
