using UnityEngine;

public class Type2Human : MonoBehaviour
{
    public ProximityNotifier notifier;
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notifier.OnNear += Rotate;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void Rotate()
  {
        transform.LookAt(target.transform);
  }
}
