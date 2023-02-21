using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform checkpoint;
    Impulse Impulse;
    GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Impulse = collision.gameObject.GetComponent<Impulse>();
            player = collision.gameObject;
            Impulse = player.GetComponent<Impulse>();
            player.transform.position = checkpoint.position;
            player.GetComponent<Rigidbody>().isKinematic = true;
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        print("ddd");
        player.GetComponent<Rigidbody>().isKinematic = false;
        Impulse.DoImpulse();
    }
}
