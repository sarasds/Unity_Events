using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; 
    public TextMeshProUGUI scoreText; // Asigna el texto en el inspector
    private int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // opcional, si quieres que persista entre escenas
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
            return;
        }
    }
    public void AddPoints(int amount)
    {
        Debug.Log(score);
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = $"Points:{score}";
    }
}
