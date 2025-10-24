using UnityEngine;

public class NotifierUI : MonoBehaviour
{
    public delegate void shieldColector(string tag);
    public event shieldColector OnMyCollision;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("cube"))
    {

       if (OnMyCollision != null)
        {
            OnMyCollision(gameObject.tag);
            gameObject.SetActive(false);
        }

    }
  }
}
