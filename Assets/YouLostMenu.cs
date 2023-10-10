using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLostMenu : MonoBehaviour
{ 
    public GameObject YouLostMenuUI;
    public void YouLost()
    { 
        YouLostMenuUI.SetActive(true);
        Time.timeScale = 1f;
    }
    
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("prest");
    }

    public void BackToTheStartMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("prest");
    }
}
