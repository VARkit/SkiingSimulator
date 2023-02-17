
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinishColision : MonoBehaviour
{
    public FinishStatistic timer;
    public NET_FinishCollision NET_FinishCollision;
    public FinStatSync sync;
    public float LocalTime;
    public float LocalCol;
    public int Player_number;
    private void OnTriggerEnter(Collider collision)
    {   
        timer.finished = true;
        if(collision.gameObject.tag == "Player")
        {
            NET_FinishCollision.ColFinished += 1;
        }
   
        LocalTime = timer.time;

        LocalCol = timer.collisions;
        if (Player_number == 1)
        {
            sync.colFirst = LocalCol;
            sync.timeFirst = LocalTime;
        }
        if (Player_number == 2)
        {
            sync.ColSecond = LocalCol;
            sync.ColSecond = LocalTime;
        }
        sync.Changed();
        if(LocalCol > 0)
        {
        timer.Sound.clip = timer.lose;
        }
        timer.Sound.Play();
    }
}
