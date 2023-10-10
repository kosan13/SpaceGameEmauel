using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private InputAction playerInput;

    public bool _gameIsPaused = false;
    public bool _OptionsTrueFalse;

    public GameObject pauseMenuUI;
    public OptionsMenu OptionsMenu;

    public void OptionsTrue()
    {
        _OptionsTrueFalse = true;
    }

    public void OptionsFalse()
    {
        _OptionsTrueFalse = false;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (_gameIsPaused)
            {
                if (_OptionsTrueFalse)
                {
                    Resume();
                }
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    { 
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        _gameIsPaused = false;
    }
    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        _gameIsPaused = true;
    }
    public void BackToTheStartMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("prest");
    }
}
