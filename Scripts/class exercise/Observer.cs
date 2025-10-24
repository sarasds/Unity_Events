using UnityEngine;

public class Observer : MonoBehaviour
{
   public Notificator notificator;
    public Renderer rend;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      notificator.OnMyChangeColour += ColourChanger;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void ColourChanger()
  {
    GetComponent<Renderer>().material.color =  new Color(Random.value, Random.value, Random.value);
  }
}
