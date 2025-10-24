using UnityEngine;

public class Type2Receiver : MonoBehaviour
{
    public Type1Notifier notifier;
     private Rigidbody rigid_body;
    public GameObject shield;
    private Renderer rend;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rigid_body =  GetComponent<Rigidbody>();
        GameObject[] allType1 = GameObject.FindGameObjectsWithTag("type1");
        for (int i = 0; i < allType1.Length; i++)
        {
            Type1Notifier notifier = allType1[i].GetComponent<Type1Notifier>();
            if (notifier != null)
            {
                notifier.OnType1Collision += MoveType2;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void MoveType2()
    {
        Vector3 direction = shield.transform.position - transform.position;
        rigid_body.AddForce(direction * 50);
  }
   void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("shieldtype1"))
        {
            collision.gameObject.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);      
        }
    }
}
