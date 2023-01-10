using UnityEngine;

public class Impulse : MonoBehaviour
{
    public float impulse;
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
        playerRB.AddForce(100000, 0, 0);
        Move.go = true;
    }
}
