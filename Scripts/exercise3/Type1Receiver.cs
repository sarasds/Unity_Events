using UnityEngine;

public class Type1Receiver : MonoBehaviour
{
    public Type2Notifier notifier;
    private Rigidbody rigid_body;
    public GameObject shield;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid_body =  GetComponent<Rigidbody>();
        GameObject[] allType2 = GameObject.FindGameObjectsWithTag("type2");
        for (int i = 0; i < allType2.Length; i++)
        {
            Type2Notifier notifier = allType2[i].GetComponent<Type2Notifier>();
            if (notifier != null)
            {
                notifier.OnmyType2Collision += MoveType1;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MoveType1()
    {
        Vector3 direction = shield.transform.position - transform.position;
        rigid_body.AddForce(direction * 10);
    }
  
    void OnCollisionEnter(Collision collision)
    { 
        if(collision.gameObject.CompareTag("shieldtype2"))
        {
            collision.gameObject.GetComponentInChildren<Renderer>().material.color = new Color(0,0,1);
      
        }
  }
}
