using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class RayCursorFollow : MonoBehaviour
{
    [Header("References")]
    public XRRayInteractor rayInteractor;   // drag the RightHand XRRayInteractor here
    public RectTransform canvasRect;        // your world-space Canvas
    public RectTransform cursorRect;        // the cursor sprite

    void Update()
    {
        // Did the ray actually hit something this frame?
        if (rayInteractor.TryGetHitInfo(out Vector3 hitPos,
                                        out Vector3 hitNormal,
                                        out int hitIndex,
                                        out bool isValid))
        {
            // Convert the world hit-point to Canvas local coords
            Vector2 localPos;
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
                    canvasRect,
                    rayInteractor.rayOriginTransform.GetComponent<Camera>().WorldToScreenPoint(hitPos),
                    rayInteractor.rayOriginTransform.GetComponent<Camera>(),
                    out localPos))
            {
                cursorRect.localPosition = localPos;
                cursorRect.gameObject.SetActive(true);
            }
        }
        else
        {
            // Hide when we’re not aiming at the monitor
            cursorRect.gameObject.SetActive(false);
        }
    }
}
