using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVOfCamera : MonoBehaviour
{
    Camera Camera;

    void Start()
    {
        Camera.stereoTargetEye = StereoTargetEyeMask.None;
    }
}
