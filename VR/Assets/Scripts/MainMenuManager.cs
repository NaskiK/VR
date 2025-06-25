using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenSettings()
    {
        Debug.Log("Settings menu not implemented yet."); // or open a panel
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
