using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadAndHelmet : MonoBehaviour
{
    public GameObject JacketBlue;
    public GameObject JacketRed;
    Transform pivot;
    OnJoinedRoom OnJoinedRoom;

    private void Update()
    {
        if (GameObject.Find("PivotForJacket") != null)
        {
            pivot = GameObject.Find("PivotForJacket").transform;
            OnJoinedRoom = GameObject.Find("netSync").GetComponent<OnJoinedRoom>();
            if (OnJoinedRoom.PlayerNum == 1)
            {
                JacketBlue.transform.position = pivot.position;
                JacketBlue.transform.rotation = pivot.rotation;
                JacketRed.SetActive(false);
            }
            else
            {
                JacketRed.transform.position = pivot.position;
                JacketRed.transform.rotation = pivot.rotation;
                JacketBlue.SetActive(false);
            }
                   
        }
    }
}
