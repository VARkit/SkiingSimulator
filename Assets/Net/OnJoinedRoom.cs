using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UltimateXR.Avatar;
using Mono.Cecil;
using Unity.VisualScripting;

public class OnJoinedRoom : MonoBehaviour
{
    public JoinRoom JoinRoom;
    public Realtime Realtime;
    public GameObject[] arrows;
    public GameObject UxrAvatar;
    public Start start;
    bool IsTransformed;
    public int PlayerNum;
    Transform LocalPivot;
    bool finalTransformed;
    public GameObject startCanv;
    void FixedUpdate()
    {
        if (Realtime.connected && !IsTransformed)
        {
            UxrAvatar.transform.position = arrows[JoinRoom.connected_players].transform.position;
            LocalPivot = arrows[JoinRoom.connected_players].transform;
            JoinRoom.connected_players += 1;
            JoinRoom.Changed();
            IsTransformed = true;
            PlayerNum = JoinRoom.PreviousValue;
        }
        if(start.Touch_count == 2 && startCanv.activeSelf != false)
        {
            UxrAvatar.transform.position  = Vector3.Lerp(UxrAvatar.transform.position, LocalPivot.GetChild(0).position, 0.015f);
        }



    }
}
