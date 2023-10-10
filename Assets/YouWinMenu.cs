using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinMenu : MonoBehaviour
{
    public GameObject YouWinMenuUI;
    public void YouWin()
    { 
        YouWinMenuUI.SetActive(true);
        Time.timeScale = 1f;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("preset");
    }

    public void BackToTheStartMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("preset");
    }
}
