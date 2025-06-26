using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string HackerScene;  // Set this in inspector to the scene you want
    public float delay = 10f;  // Delay in seconds

    public void ChangeSceneWithDelay()
    {
        StartCoroutine(DelayedSceneChange());
    }

    private System.Collections.IEnumerator DelayedSceneChange()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("HackerScene");
    }
}
