using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class highScore : MonoBehaviour
{
    [SerializeField] private Text currentTime;
    [SerializeField] private Text highscoreTime;
    [SerializeField] private Text newText;

    void Start()
    {
        float temp = PlayerPrefs.GetFloat("globalTimer");
        float temp2 = PlayerPrefs.GetFloat("highscoreTime");
        currentTime.text = temp.ToString("0");
        newText.enabled = false;
        
        if (temp2 > 0)
        {
            highscoreTime.text = temp2.ToString("0");
        }
        if (temp < temp2 || temp2 == 0)
        {
            PlayerPrefs.SetFloat("highscoreTime", temp);
            highscoreTime.text = temp.ToString("0");
            newText.enabled = true;
            
        }
        
    }
    public void ResetHighScore()
    {
        PlayerPrefs.SetFloat("highscoreTime", 0);
        float temp2 = 0;
        highscoreTime.text = temp2.ToString("0");
        newText.enabled = false;
    }
}
