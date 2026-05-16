using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject startMainMenu;
    public GameObject levelSelect;

    private void Start()
    {
        startMainMenu.SetActive(true);
    }

    public void GoToLevelSelect()
    {
        startMainMenu.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void BackToMainMenu()
    {
        levelSelect.SetActive(false);
        startMainMenu.SetActive(true);
    }

    public void StartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}