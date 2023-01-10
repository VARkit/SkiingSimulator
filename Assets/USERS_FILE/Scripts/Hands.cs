using UnityEngine;

public class Hands : MonoBehaviour
{
    public PlayerMove Move;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hands")
        {
            Move.tormoz = true;
            Move.go = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "hands")
        {
            Move.tormoz = false;
            Move.go = true;
        }
    }
}
