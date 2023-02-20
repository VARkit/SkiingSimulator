using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shlag_Rot : MonoBehaviour
{
    Animator Animator;

    private void Start()
    {
        Animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Animator.SetTrigger("DoRotate");
    }
}
