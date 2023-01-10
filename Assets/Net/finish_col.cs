
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_col : MonoBehaviour
{
    public FinishStatistic timer;
    public NET_FinishCollision Network;
    private void OnTriggerEnter(Collider collision)
    {
        Network.plusCount();
        timer.finished = true;
        if(timer.collisions > 0)
        {
            if(timer.collisions > 0)
            {
                timer.Sound.clip = timer.lose;
            }
        }
        timer.Sound.Play();
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
