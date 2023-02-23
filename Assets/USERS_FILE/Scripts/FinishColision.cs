
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinishColision : MonoBehaviour
{
    public FinishStatistic timer;
    public NET_FinishCollision NET_FinishCollision;
    public float LocalTime;
    public float LocalCol;
    public float LocalCol2;
    public PlayerMove PlayerMove;
    public GameObject[] finishPivots;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            NET_FinishCollision.ColFinished += 1;
            print(collision.gameObject.name);
        }

        gameObject.GetComponent<BoxCollider>().enabled = false;
        LocalCol = timer.collisions;

        if(LocalCol > 0)
        {
            timer.Sound.clip = timer.lose;
        }

        timer.Sound.Play();
    }
}
