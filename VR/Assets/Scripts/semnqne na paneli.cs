using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    // Assign these in the Inspector
    public GameObject panelToDisable;
    public GameObject panelToEnable;

    // Call this from the UI Button
    public void SwitchPanels()
    {
        if (panelToDisable != null)
            panelToDisable.SetActive(false);

        if (panelToEnable != null)
            panelToEnable.SetActive(true);
    }
}
