using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffFinishStat : MonoBehaviour
{
    public NET_FinishCollision NET_FinishCollision;
    public GameObject finCanv;

    void Update()
    {
        if(NET_FinishCollision.Prev == 2)
        {
            finCanv.SetActive(true);
        }
    }
}
