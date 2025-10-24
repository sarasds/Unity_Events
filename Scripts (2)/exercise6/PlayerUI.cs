using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public NotifierUI notifier;
    public int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    GameObject[] allShieldsType2 = GameObject.FindGameObjectsWithTag("shieldtype2");
        for (int i = 0; i < allShieldsType2.Length; i++)
        {
            NotifierUI notifier = allShieldsType2[i].GetComponent<NotifierUI>();
            if (notifier != null)
            {
                notifier.OnMyCollision += ShieldCounter;
            }

        }   
        GameObject[] allShieldsType1 = GameObject.FindGameObjectsWithTag("shieldtype1");
        for (int i = 0; i < allShieldsType1.Length; i++)
        {
            NotifierUI notifier = allShieldsType1[i].GetComponent<NotifierUI>();
            if (notifier != null)
            {
                notifier.OnMyCollision += ShieldCounter;
            }

        }   
        
         }

    // Update is called once per frame
    void Update()
    {

    }
    
    void ShieldCounter(string tag) 
  {
        if (tag == "shieldtype1")
        {
            if (ScoreManager.Instance != null)
                ScoreManager.Instance.AddPoints(5);
        }
        if (tag == "shieldtype2")
        {
            if (ScoreManager.Instance != null)
                ScoreManager.Instance.AddPoints(10);
        }
         
  }
}
