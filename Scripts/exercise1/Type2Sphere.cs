using UnityEngine;

public class Type2Sphere : MonoBehaviour
{
    public NotifierSpheres notifier;
    private Rigidbody rigid_body;

/*     private float speed = 2.0f;
 */    private GameObject cylinder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid_body =  GetComponent<Rigidbody>();
        cylinder = GameObject.FindWithTag("cylinder");
        notifier.OnMyCollision += MoveToCylinder;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void MoveToCylinder()
  {
        Vector3 direction = cylinder.transform.position - transform.position;
        rigid_body.AddForce(direction * 50);
  }
}
