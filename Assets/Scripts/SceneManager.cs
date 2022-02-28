using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    [SerializeField] float delayInSeconds = 0.5f;

    public void LoadStartMenu(float delay)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void LoadGameScene()
    {
        FindObjectOfType<GameSession>().ResetGame();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad(delayInSeconds));
    }

    private IEnumerator WaitAndLoad(float delay)
    {
        yield return new WaitForSeconds(delay);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
