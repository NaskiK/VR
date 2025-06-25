using UnityEngine;
using System.Collections;

public class PanelAutoSwitcher : MonoBehaviour
{
    [Header("Panels")]
    public GameObject panelToAutoClose;     // The panel that should deactivate
    public GameObject panelToActivateNext;  // The panel that should activate after delay

    [Header("Timing")]
    public float delaySeconds = 30f;         // Time to wait before switching

    // Call this when the auto-close panel is activated
    public void StartAutoSwitch()
    {
        StartCoroutine(SwitchAfterDelay());
    }

    private IEnumerator SwitchAfterDelay()
    {
        yield return new WaitForSeconds(delaySeconds);

        if (panelToAutoClose != null)
            panelToAutoClose.SetActive(false);

        if (panelToActivateNext != null)
            panelToActivateNext.SetActive(true);
    }
}
