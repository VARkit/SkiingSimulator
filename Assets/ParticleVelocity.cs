using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleVelocity : MonoBehaviour
{
    public Rigidbody rb;
    public ParticleSystem ps;

    void Update()
    {
        ps.startSpeed = rb.velocity.z;
    }
}
