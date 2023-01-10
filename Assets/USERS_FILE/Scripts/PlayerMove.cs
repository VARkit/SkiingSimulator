using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform Camera;
    public float Z;
    private float _x;
    public bool go;
    public bool tormoz;
    public Rigidbody rb;
    public Transform ski;
    public float _q;

    private void FixedUpdate()
    {
        if (tormoz)
        {
            if (gameObject.GetComponent<Rigidbody>().velocity.x > 0)
            {
                go = false;
                gameObject.GetComponent<Rigidbody>().velocity += new Vector3(-1.5f, 0, 0);
                if (gameObject.GetComponent<Rigidbody>().velocity.x <= 0)
                {
                    gameObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }

        if (go)
        {
            Z = Camera.localRotation.z;
            _x = Camera.localRotation.x;

            if (Camera.localRotation.w > 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Camera.localRotation.z * rb.velocity.x * 5 * rb.velocity.x / 50);
                ski.transform.localRotation = new Quaternion(ski.transform.localRotation.x, -Camera.localRotation.z, ski.transform.localRotation.z, ski.transform.localRotation.w);
            }
            if (Camera.localRotation.w < 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -Camera.localRotation.z * rb.velocity.x * 5 * rb.velocity.x / 50);
                ski.transform.localRotation = new Quaternion(ski.transform.localRotation.x, Camera.localRotation.z, ski.transform.localRotation.z, ski.transform.localRotation.w);
            }

            //if (_x > _q)
            //{
            //    // Player.addForce()
            //}
            //else if (_x < _q)
            //{
            //    rb.drag = _x / 1.2f;
            //}

            rb.drag = Camera.localRotation.z / 1.2f;
        }
    }


}
