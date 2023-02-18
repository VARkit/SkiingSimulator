using UnityEngine;

public class Impulse : MonoBehaviour
{
    public int impulseStart;
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
        playerRB.AddForce(0 , 0, impulseStart);
        Move.go = true;
    }
}
