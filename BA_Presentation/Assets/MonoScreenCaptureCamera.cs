using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoScreenCaptureCamera : MonoBehaviour
{
    private Camera captureCamera;

    void Start()
    {
        captureCamera = GetComponent<Camera>();
    }

    void Update()
    {
        captureCamera.fieldOfView = Camera.main.fieldOfView;
    }
}
