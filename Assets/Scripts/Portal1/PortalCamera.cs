using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera,portal,otherPortal;

    private void Update() 
    {
        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
        transform.position = portal.position + playerOffsetFromPortal;

        float angularDiffBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);

        Quaternion portalRotationDiff = Quaternion.AngleAxis(angularDiffBetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationDiff * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }

}
