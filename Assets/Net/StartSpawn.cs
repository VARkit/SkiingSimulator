using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawn : MonoBehaviour
{
    JoinRoom joinRoom;
    bool joinDone;
    void Awake()
    {
        joinRoom = GameObject.Find("spawner").GetComponent<JoinRoom>();
        joinRoom.connected_players += 1;
        joinRoom.Changed();
        joinDone = true;
        
        

    }
    private void Update()
    {
        gameObject.transform.position = GameObject.Find("SkiMeshes").transform.position;
        gameObject.transform.rotation = GameObject.Find("SkiMeshes").transform.rotation;

    }
}
