using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager instance;

    public GameObject settingsPanel;

    public AudioSource buttonSource;
    public AudioClip buttonClickSound;

    private bool isOpen = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        settingsPanel.SetActive(false);
    }

    public void ToggleSettings()
    {
        if (isOpen)
        {
            CloseSettings();
        }
        else
        {
            OpenSettings();
        }
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        isOpen = true;

        Time.timeScale = 0f;
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
        isOpen = false;

        Time.timeScale = 1f;
    }

    public void ResumeGame()
    {
        PlayButtonSound();

        settingsPanel.SetActive(false);
        isOpen = false;

        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        PlayButtonSound();

        Time.timeScale = 1f;

        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenu()
    {
        PlayButtonSound();

        Time.timeScale = 1f;

        SceneManager.LoadScene("StartMenu");
    }

    public void PlayButtonSound()
    {
        if (buttonSource != null && buttonClickSound != null)
        {
            buttonSource.PlayOneShot(buttonClickSound);
        }
    }
}