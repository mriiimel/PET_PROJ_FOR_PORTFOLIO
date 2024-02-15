using System;
using Cinemachine;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _cinemachineVirtual;
    [SerializeField] private Hero _heroUnit;
    private Vector3 _mousInput;
    private Camera _camera;
    private void Start()
    {
        _mousInput = Input.mousePosition;
        var transform1 = _heroUnit.transform;
        _cinemachineVirtual.LookAt = transform1;
        _cinemachineVirtual.Follow = transform1;
    }

    private void Update()
    {
        
        var something = _cinemachineVirtual.State.PositionCorrection;
        something = _mousInput;
    }
}
