using UnityEngine;
using UnityEngine.VFX;

public class Fov_Change : MonoBehaviour
{
    public Rigidbody playerRB;
    Camera Camera;
    public VisualEffect VisualEffect;

    void Start()
    {
        Camera = Camera.main;
    }

    void LateUpdate()
    {
        Camera.fieldOfView = 90 + playerRB.velocity.x * 1.5f;
        VisualEffect.SetFloat("SpawnRate", playerRB.velocity.x * 6);
    }
}
