
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishColision : MonoBehaviour
{
    public FinishStatistic timer;
    private void OnTriggerEnter(Collider collision)
    {
        timer.finished = true;
        if(timer.collisions > 0)
        {
            if(timer.collisions > 0)
            {
                timer.Sound.clip = timer.lose;
            }
        }
        timer.Sound.Play();

    }
}
