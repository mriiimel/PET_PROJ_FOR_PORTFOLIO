using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public  class CameraBase : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _vCam; 
    protected Vector3 _camMovement;
    public void OnCameraRotate(InputAction.CallbackContext value)
    {
        _camMovement = value.ReadValue<Vector2>();
        Vector3 camPos = new Vector3(0, _camMovement.x, 0);
        

    }

    //protected void CameraRotate(Vector3 camRotation)
    //{
    //    _vCam.ForceCameraPosition(camRotation, Quaternion.identity);
    //}
}
