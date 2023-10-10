using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinTheGame : MonoBehaviour
{
    public void BackToTheStartMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("prest");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
