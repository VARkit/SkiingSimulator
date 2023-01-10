using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TouchButton : MonoBehaviour
{
    public Start Start;

    public void OnTouch()
    {
        Start.plusCount();
    }
}
