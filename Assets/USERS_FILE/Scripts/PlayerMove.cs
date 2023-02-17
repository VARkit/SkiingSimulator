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
            if (gameObject.GetComponent<Rigidbody>().velocity.z < 0)
            {
                go = false;
                gameObject.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 3);
                if (gameObject.GetComponent<Rigidbody>().velocity.z >= 0)
                {
                    gameObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }

        else if (go)
        {
            Z = Camera.localRotation.z;
            _x = Camera.localRotation.x;

            if (Camera.localRotation.w > 0)
            {
                rb.velocity = new Vector3(Camera.localRotation.z * rb.velocity.z * 5 * rb.velocity.z / 50, rb.velocity.y, rb.velocity.z);
                ski.transform.localRotation = new Quaternion(ski.transform.localRotation.x, -Camera.localRotation.z, ski.transform.localRotation.z, ski.transform.localRotation.w);
            }
            if (Camera.localRotation.w < 0)
            {
                rb.velocity = new Vector3( -Camera.localRotation.z * rb.velocity.z * 5 * rb.velocity.z / 50, rb.velocity.y, rb.velocity.x);
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
