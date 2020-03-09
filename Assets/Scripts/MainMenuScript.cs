using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject MainMenuPanel;
    [SerializeField] GameObject CreditsPanel;
    [SerializeField] GameObject ControlsPanel;
    public void Start()
    {
        MainMenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        ControlsPanel.SetActive(false);
    }
    public void ShowMainMenu()
    {
        MainMenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        ControlsPanel.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("DevLevel");
    }
    public void ShowCredits()
    {
        MainMenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        ControlsPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void ShowControls()
    {
        MainMenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        ControlsPanel.SetActive(true);
    }
}
