using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MessageSender : MonoBehaviour
{
    [Header("UI References")]
    public InputField inputField;           // Assign in Inspector
    public Text feedbackText;               // Assign: a Text UI element to show "Sent"
    public GameObject panelToDisable;       // Assign the current panel
    public GameObject panelToEnable;        // Assign the next panel
    public Button sendButton;               // Assign the send/enter button

    void Start()
    {
        // Optional: clear the feedback message on start
        if (feedbackText != null)
            feedbackText.text = "";

        // Add the button click listener
        sendButton.onClick.AddListener(OnSend);
    }

    public void OnSend()
    {
        if (string.IsNullOrEmpty(inputField.text)) return;

        // Show "Sent" text
        if (feedbackText != null)
            feedbackText.text = "Sent";

        // Start the coroutine to switch panels after delay
        StartCoroutine(SwitchPanelsAfterDelay(3f));
    }

    IEnumerator SwitchPanelsAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (panelToDisable != null)
            panelToDisable.SetActive(false);

        if (panelToEnable != null)
            panelToEnable.SetActive(true);
    }
}
