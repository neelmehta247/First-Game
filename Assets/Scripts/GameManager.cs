using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    
    public void EndGame()
    {
        if (gameHasEnded) return;

        gameHasEnded = true;
        Invoke(nameof(Restart), 1f);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
