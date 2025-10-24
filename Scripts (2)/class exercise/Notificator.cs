using UnityEngine;

public class Notificator : MonoBehaviour
{
    public delegate void changeColour();
    public event changeColour OnMyChangeColour;
   
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
    if (OnMyChangeColour != null){
      OnMyChangeColour();
    }
  }
    
}
