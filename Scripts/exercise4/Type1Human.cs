using UnityEngine;

public class Type1Human : MonoBehaviour
{
    public ProximityNotifier notifier;
    public GameObject shield;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notifier.OnNear += Teleport;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void Teleport()
  {
        transform.position = shield.transform.position;
  }
}
