using UnityEngine;
using UnityEngine.Events;

public class UIRayActivation : MonoBehaviour
{
    [SerializeField] private Transform linkedHandPosition;
    [SerializeField] private LayerMask layerToHit;
    [SerializeField] private float maxDistanceFromCanvas;

    [Header("UI Hover Events")]
    public UnityEvent onUIHoverStart;
    public UnityEvent onUIHoverEnd;

    enum CurrentInteractorState
    {
        DefaultMode,
        UIMode
    }
    private CurrentInteractorState currentInteractorMode;

    private void Awake() => currentInteractorMode = CurrentInteractorState.DefaultMode;

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(linkedHandPosition.position, linkedHandPosition.forward, out hit, maxDistanceFromCanvas, layerToHit))
        {
            if(currentInteractorMode != CurrentInteractorState.UIMode)
            {
                onUIHoverStart.Invoke();
                currentInteractorMode = CurrentInteractorState.UIMode;
            }
        }
        else
        {
            if(currentInteractorMode == CurrentInteractorState.UIMode)
            {
                onUIHoverEnd.Invoke();
                currentInteractorMode=CurrentInteractorState.DefaultMode;
            }
        }
    }
}
