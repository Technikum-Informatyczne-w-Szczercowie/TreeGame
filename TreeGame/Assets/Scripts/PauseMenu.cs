 using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject mainGamePanel;
    private bool _isPaused;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            
            
            if (_isPaused)
                ResumeGame();
            else
                PauseGame();
    }

    void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        
        mainGamePanel.SetActive(false);
        pausePanel.SetActive(true);

        Time.timeScale = 0f;
        _isPaused = true;
    }

    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
        mainGamePanel.SetActive(true);
        pausePanel.SetActive(false);
        
        Time.timeScale = 1f;
        _isPaused = false;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu");
    }
    
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
