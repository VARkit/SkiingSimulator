using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_finish : MonoBehaviour
{
    public timer_dist timer;
    public bool IsFinish;
    private void OnTriggerEnter(Collider collision)
    {
        timer.start_finish();
        if (IsFinish)
        {
        }
    }
}
