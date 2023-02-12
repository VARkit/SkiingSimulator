using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawn : MonoBehaviour
{

    private void Update()
    {
        gameObject.transform.position = GameObject.Find("SkiMeshes").transform.position;
        gameObject.transform.rotation = GameObject.Find("SkiMeshes").transform.rotation;

    }
}
