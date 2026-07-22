using UnityEngine;

public class ControllerFollow : MonoBehaviour
{
    public Transform targetController;
    
    [Tooltip("Adjust these values to offset the body from the controller")]
    public Vector3 positionOffset;

    void Update()
    {
        if (targetController != null)
        {
            // Applies the controller's position, plus your custom offset
            transform.position = targetController.position + positionOffset;
            
            // We removed the rotation line! Now the body will stay perfectly upright
            // instead of spinning wildly when you twist your wrist.
        }
    }
}