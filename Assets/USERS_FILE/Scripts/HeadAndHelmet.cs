using Normal.Realtime;
using Oculus.Platform;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadAndHelmet : MonoBehaviour
{
    public GameObject JacketBlue;
    public GameObject JacketRed;
    Transform pivot;
    OnJoinedRoom OnJoinedRoom;
    public Transform Camera;
    GameObject MainJacket;
    private void Update()
    {
        if (GameObject.Find("PivotForJacket") != null)
        {
            pivot = GameObject.Find("PivotForJacket").transform;
            OnJoinedRoom = GameObject.Find("netSync").GetComponent<OnJoinedRoom>();
        }
    }
}
