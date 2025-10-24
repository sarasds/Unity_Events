using UnityEngine;

public class Type2Notifier : MonoBehaviour
{
    public delegate void smth();
    public event smth OnmyType2Collision;
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

       if (OnmyType2Collision != null)
        {
            OnmyType2Collision();
        }

    }
  }
}
