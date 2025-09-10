using UnityEngine;

public class PlayerCarControl : MonoBehaviour
{
    //Global variables
    public float moveSpeed;
    public float turnSpeed;

    [Range(-1f,1f)]public float horizontalInput;
    [Range(-1f,1f)]public float verticalInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        //Move forward and backward
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed * verticalInput);

        //Turn
        transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
