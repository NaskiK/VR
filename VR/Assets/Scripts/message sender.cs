using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SendAndSwitch : MonoBehaviour
{
    [Header("UI References")]
    public Text feedbackText;               // Assign a Text UI element (e.g. to show "Sent")
    public GameObject panelToDisable;       // The current panel to hide
    public GameObject sent_password_notification_panel;
    public GameObject panelToEnable;        // The next panel to show

    // Call this from the Button's OnClick
    public void OnSendClicked()
    {
        if (feedbackText != null)
            feedbackText.text = "Sent";
            
            panelToDisable.SetActive(false);
            sent_password_notification_panel.SetActive(true);

        StartCoroutine(SwitchPanelsAfterDelay(3f));
    }

    private IEnumerator SwitchPanelsAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        sent_password_notification_panel.SetActive(false);
        if (panelToEnable != null)
            panelToEnable.SetActive(true);
    }
}
