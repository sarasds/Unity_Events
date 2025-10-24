using UnityEngine;

public class Type1Notifier : MonoBehaviour
{
    public delegate void move();
    public event move OnType1Collision;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
  {
       if (collision.gameObject.CompareTag("cube"))
    {

       if (OnType1Collision != null)
        {

            OnType1Collision();
      }

    }
  }
}
