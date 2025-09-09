using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Global Variables
    [Header("Movement Variables")]
    public float moveSpeed;
    public float turnSpeed;

    [Header("Input Variables")]
    [Range(-1,1)] public float verticalInput;
    [Range(-1, 1)] public float horizontalInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Collect Input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Move forward AND backward
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed * verticalInput);

        //Turning
        transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime * horizontalInput);


    }
}
