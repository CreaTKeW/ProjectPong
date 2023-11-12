using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private static bool isPaused = false;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else { PauseGame(); }
        }
    }

    private void PauseGame()
    {
        pauseMenu.SetActive(true);
        audioSource.Pause();
        Time.timeScale = 0f;
        isPaused = true;
    }

    private void ResumeGame()
    {
        pauseMenu.SetActive(false);
        audioSource.UnPause();
        Time.timeScale = 1f;
        isPaused = false;
    }

    private void RestartGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void MainMenu()
    {
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    private void SettingsMenu()
    {
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
