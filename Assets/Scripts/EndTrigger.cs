using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;   
    void OnTriggerEnter ()
    {
        if (gameManager.gameHasEnded == false)
        {
            gameManager.CompleteLevel();
            FindObjectOfType<Score>().setGlobalTimer();
        }
    }
}
