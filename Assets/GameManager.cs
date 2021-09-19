using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool playerIsDead = false;
    public float restartDelay = 1f;

    public void GameOver()
    {
        if (playerIsDead == false)
        {
            playerIsDead = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("StartGame");
    }

    public void Ganaste()
    {
        Debug.Log("Ganaste");
    }
}
