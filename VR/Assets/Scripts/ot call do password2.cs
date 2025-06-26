using UnityEngine;
using System.Collections;

public class PanelAutoSwitcherrr : MonoBehaviour
{
    [Header("Optional – panel that should disappear after the wait")]
    public GameObject panelToAutoClose;

    [Header("Optional – panel that should disappear after the wait")]
    public GameObject panelToAutoCloses;

    [Header("Optional – panel that should disappear after the wait")]
    public GameObject panelToAutoClosess;


    [Header("What should appear after the wait")]
    public GameObject panelToActivateNext;

    [Header("Timing")]
    public float delaySeconds = 40f;

    private void OnEnable()                 // fires when THIS panel becomes active
    {
        StartCoroutine(SwitchAfterDelay());
    }

    private IEnumerator SwitchAfterDelay()
    {
        yield return new WaitForSecondsRealtime(delaySeconds); // ignores Time.timeScale

        if (panelToActivateNext) panelToActivateNext.SetActive(true);
        if (panelToAutoClose) panelToAutoClose.SetActive(false);
        if (panelToAutoCloses) panelToAutoCloses.SetActive(false);
        if (panelToAutoClosess) panelToAutoClosess.SetActive(false);


    }
}
