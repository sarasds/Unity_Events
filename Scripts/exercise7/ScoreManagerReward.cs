using UnityEngine;
using TMPro;
public class ScoreManagerReward : MonoBehaviour
{
    public static ScoreManagerReward Instance;
    public TextMeshProUGUI scoreText; // Asigna el texto en el inspector
    public TextMeshProUGUI Reward;
    private int score = 0;
    private int nextRewardThreshold = 100;

    private float rewardDisplayDuration = 3f;
    private float rewardHideTime = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Awake()
    {
        // Singleton opcional (si quieres usar ScoreManagerReward.Instance.AddPoints())
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        UpdateScoreText();
        
    
         Reward = GameObject.Find("Reward")?.GetComponent<TextMeshProUGUI>();
        if (Reward == null)
            Debug.LogError("⚠️ No se encontró ningún objeto llamado 'RewardText' en la escena.");
        if (Reward != null)
            Reward.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {   
        if (Reward != null && Reward.gameObject.activeSelf && Time.time >= rewardHideTime)
        {
            Reward.gameObject.SetActive(true);
        }
    }
     public void AddPoints(int amount)
    {
        score += amount;
        UpdateScoreText();
        CheckForReward();
    }

    void UpdateScoreText()
    {
         if (scoreText != null)
            scoreText.text = $"Points: {score}";
        else
            Debug.LogWarning("⚠️ ScoreText no asignado en el inspector.");

    }

        void CheckForReward()
    {
        if (score >= nextRewardThreshold)
        {
            if (Reward != null)
              Reward.gameObject.SetActive(true);
              nextRewardThreshold += 100;
        }
    }

    /* void ShowReward(string message)
    {
        if (Reward == null) return;

        Reward.text = message;
        Reward.gameObject.SetActive(true);
        rewardHideTime = Time.time + rewardDisplayDuration;
    } */
}
