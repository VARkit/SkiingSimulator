using Normal.Realtime;
using Oculus.Platform;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadAndHelmet : MonoBehaviour
{
    public GameObject JacketBlue;
    public GameObject JacketRed;
    public GameObject HeadModel;
    public GameObject SkiMesh;
    public Transform Head;
    public PlayerMove PlayerMove;
    private void Update()
    {
        if(GameObject.Find("Player") != null)
        {
            PlayerMove = GameObject.Find("Player").GetComponent<PlayerMove>();
            
            if (Head.localRotation.w > 0 && PlayerMove.go)
            {
                SkiMesh.transform.localRotation = new Quaternion(SkiMesh.transform.localRotation.x, -Head.localRotation.z, SkiMesh.transform.localRotation.z, SkiMesh.transform.localRotation.w);

            }
            if (Head.localRotation.w < 0 && PlayerMove.go)
            {
               SkiMesh.transform.localRotation = new Quaternion(SkiMesh.transform.localRotation.x, Head.localRotation.z, SkiMesh.transform.localRotation.z, SkiMesh.transform.localRotation.w);
            }
        }
        
    }
}
