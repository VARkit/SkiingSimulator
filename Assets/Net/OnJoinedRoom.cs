using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UltimateXR.Avatar;
using Mono.Cecil;
using Unity.VisualScripting;
using UnityEngine.Serialization;

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
    RealtimeAvatar NonBinaryAvatar;
    [SerializeField]
    private RealtimeAvatar LocalAvatar;
    [SerializeField]
    private RealtimeAvatar RemoteAvatar;
    public Transform Chest;
    public Camera camera;
    void FixedUpdate()
    {
        
        if (Realtime.connected && !IsTransformed)
        {
            if (LocalAvatar == null | RemoteAvatar == null)
            {
                NonBinaryAvatar = GameObject.FindWithTag("Avatar").GetComponent<RealtimeAvatar>();
                if (NonBinaryAvatar.isOwnedLocallyInHierarchy)
                {
                    LocalAvatar = NonBinaryAvatar;
                    NonBinaryAvatar.tag = "Untagged";
                }
                else
                {
                    NonBinaryAvatar.tag = "Untagged";
                    RemoteAvatar = NonBinaryAvatar;
                }
                print(NonBinaryAvatar.ownerIDSelf);
            } 
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
        if ((LocalAvatar == null | RemoteAvatar == null) && Realtime.connected)
            {
                if(GameObject.FindWithTag("Avatar") != null)
                {
                    NonBinaryAvatar = GameObject.FindWithTag("Avatar").GetComponent<RealtimeAvatar>();
                }
                if (NonBinaryAvatar.isOwnedLocallyInHierarchy)
                {
                    LocalAvatar = NonBinaryAvatar;
                    NonBinaryAvatar.tag = "Untagged";
                }
                else
                {
                    NonBinaryAvatar.tag = "Untagged";
                    RemoteAvatar = NonBinaryAvatar;
                }
                LocalAvatar.GetComponent<HeadAndHelmet>().JacketRed.SetActive(false);
                LocalAvatar.GetComponent<HeadAndHelmet>().JacketBlue.SetActive(false);
                LocalAvatar.GetComponent<HeadAndHelmet>().HeadModel.SetActive(false);
              //  LocalAvatar.GetComponent<HeadAndHelmet>().SkiMesh.SetActive(false);
        }
        else if (LocalAvatar != null && RemoteAvatar != null && (RemoteAvatar.GetComponent<HeadAndHelmet>().JacketRed.activeSelf == true | RemoteAvatar.GetComponent<HeadAndHelmet>().JacketBlue.activeSelf == true))
        {
            if (PlayerNum == 1)
            {
                RemoteAvatar.GetComponent<HeadAndHelmet>().JacketBlue.SetActive(false);
            }
            else
            {
                RemoteAvatar.GetComponent<HeadAndHelmet>().JacketRed.SetActive(false);
            }

        }
    }
}
