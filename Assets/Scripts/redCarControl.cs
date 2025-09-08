using UnityEngine;

public class redCarControl : MonoBehaviour
{
    //Global Variables

    public string carName;
    public float moveSpeed;
    public float turnSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log will write a message in the console
        Debug.Log("Hello world!");

        Debug.Log( carName + " is ready to race!");
    }

    // Update is called once per frame
    void Update()
    {
        //Make the car move forward
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);

        //Make the car turn
        transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime); 



    }
}
