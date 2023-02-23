using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCollision : MonoBehaviour
{
    public WrongColision Col;

    private void Start()
    {
        Col = gameObject.transform.parent.Find("stolb_low").gameObject.GetComponent<WrongColision>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && Col.playerNum == GameObject.Find("netSync").GetComponent<OnJoinedRoom>().PlayerNum)
        {
            Col.OnWrongCol();
            Col.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<Rigidbody>().velocity -= new Vector3(2, 0, 0);
            gameObject.transform.parent.gameObject.GetComponent<Animator>().SetTrigger("hit");
        }
    }
}
