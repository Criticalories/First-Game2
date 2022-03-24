using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private Transform player;
    [SerializeField] private Text scoreText;
    private float localTimer;

    void Start()
    {
        player = GameObject.Find("Player").transform;
        localTimer = PlayerPrefs.GetFloat("globalTimer");
    }
    void Update()
    {
        localTimer += Time.deltaTime;
        scoreText.text = localTimer.ToString("0");     
    }
    public void setGlobalTimer()
    {    
        PlayerPrefs.SetFloat("globalTimer", localTimer);
    }

}
