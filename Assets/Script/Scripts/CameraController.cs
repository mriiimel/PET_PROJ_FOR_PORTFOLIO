using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : CameraBase
{
    private Vector3 _camRotation;

    private void Awake()
    {
        _camRotation = _camMovement;
    }

    private void Update()
    {
        _camRotation = _camMovement;
    }

    private void LateUpdate()
    {
        //CameraRotate(_camRotation);
    }

    
}
