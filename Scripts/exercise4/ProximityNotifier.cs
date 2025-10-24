using UnityEngine;

public class ProximityNotifier : MonoBehaviour
{
    public delegate void near();
    public event near OnNear;

    public Transform referenceObject; // Asignar en el inspector
    public float triggerDistance = 5f;

    private bool eventTriggered = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (referenceObject == null) return;

        float distance = Vector3.Distance(transform.position, referenceObject.position);

        if (distance <= triggerDistance && !eventTriggered)
        {
           // Debug.Log("📢 Proximidad detectada con el objeto de referencia");
            eventTriggered = true;
            OnNear();
        }
    }
}
