using UnityEngine;

public class Impulse : MonoBehaviour
{
    public Vector3 impulseStart;
    GameObject player;
    Rigidbody playerRB;
    public PlayerMove Move;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerRB = player.GetComponent<Rigidbody>();

    }
    public void DoImpulse()
    {
        playerRB.velocity = impulseStart * -1;
        Move.go = true;
    }
}
