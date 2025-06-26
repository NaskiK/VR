using UnityEngine;

public class PanelSwitcherr : MonoBehaviour
{
    // Assign these in the Inspector
    public GameObject panelToDisable;
    public GameObject panelToEnable;

    // Call this from the UI Button
    public void SwitchPanelss()
    {
        if (panelToDisable != null)
            panelToDisable.SetActive(false);

        if (panelToEnable != null)
            panelToEnable.SetActive(true);
    }
}