using UnityEngine;

public class Type1Sphere : MonoBehaviour
{
    public NotifierSpheres notifier;
    private Rigidbody rigid_body;
    private GameObject sphere;
/*     private float speed = 2.0f;
 */    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid_body =  GetComponent<Rigidbody>();
        sphere = GameObject.FindWithTag("gogethim");
        notifier.OnMyCollision += MoveToSphere;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void MoveToSphere()
    {

        Vector3 direction = sphere.transform.position - transform.position;
        rigid_body.AddForce(direction * 10);
        /*direction.y = 0;
        direction = direction.normalized;
        transform.Translate((direction) * speed * Time.deltaTime); */
    }
}
