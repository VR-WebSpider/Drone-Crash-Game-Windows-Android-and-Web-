using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitPopupManager : MonoBehaviour
{
    public GameObject exitPopup;
    public GameObject playButton;

    public string homeSceneName = "HomeScreen";


    public void ShowExitPopup()
    {
        exitPopup.SetActive(true);
        Time.timeScale = 0f;
        playButton.SetActive(false);
    }


    public void HideExitPopup()
    {
        exitPopup.SetActive(false);
        playButton.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        playButton.SetActive(false);
    }


    public void ExitGame()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(homeSceneName);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (exitPopup.activeSelf)
            {
                HideExitPopup();
            }
            else
            {
                ShowExitPopup();
            }
        }
    }
}
