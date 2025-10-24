using UnityEngine;

public class MovePlayers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rigid_body;
    /* public float force = 10000.0f; */
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid_body = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void FixedUpdate()
    {
        float horizontal_input = Input.GetAxis("Vertical");
        float vertical_input = Input.GetAxis("Horizontal");
        // Move translation along the object's z-axis
        // Vector3 forceDirection = new Vector3(translate_horizontal, 0.0f, translate_vertical);

        rigid_body.AddForce(Vector3.forward * vertical_input * 15);
        rigid_body.AddForce(Vector3.right * horizontal_input * 15);
    }
}
