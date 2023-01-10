using UnityEngine;

public class Vorota_discval : MonoBehaviour
{
    public string TagDiscval;
    public GameObject Lose;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == TagDiscval)
        {
            print("Discvalification");
            Lose.SetActive(true);
        }
    }
}
