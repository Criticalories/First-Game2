using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;

    [SerializeField] private float restartDelay = 1f;
    [SerializeField] private GameObject completeLevelUI;

    public void ResetButton()
    {
        PlayerPrefs.SetFloat("globalTimer", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    
    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
    
    public void EndGame ()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            
            Invoke("Restart", restartDelay);
        }
    }
    private void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<Score>().setGlobalTimer();
    }
}
