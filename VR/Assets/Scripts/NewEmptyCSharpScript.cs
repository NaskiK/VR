using UnityEngine;
using UnityEngine.UI;

public class HidePanelOnClick : MonoBehaviour
{
    public GameObject Canvas;  // Drag your panel here in Inspector

    void Start()
    {
        // Make sure there's a Button component on this GameObject
        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(HidePanel);
        }
        else
        {
            Debug.LogError("No Button component found on this GameObject.");
        }
    }

    void HidePanel()
    {
        if (Canvas != null)
        {
            Canvas.SetActive(false);
        }
        else
        {
            Debug.LogError("panelToHide is not assigned.");
        }
    }
}
