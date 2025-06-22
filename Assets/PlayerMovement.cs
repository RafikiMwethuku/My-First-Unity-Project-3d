using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    //Rigidbody rigidBody;

    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //rigidBody = rigidBody ? rigidBody : GetComponent<Rigidbody>();
        
        rb.useGravity = false;

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
