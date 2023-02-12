using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UltimateXR.Avatar;

public class OnJoinedRoom : MonoBehaviour
{
    public JoinRoom JoinRoom;
    public Realtime Realtime;
    public GameObject[] arrows;
    public GameObject UxrAvatar;
    bool IsTransformed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Realtime.connected && !IsTransformed)
        {
            UxrAvatar.transform.position = arrows[JoinRoom.connected_players].transform.position;
            JoinRoom.connected_players += 1;
            JoinRoom.Changed();
            IsTransformed = true;
        }
    }
}
