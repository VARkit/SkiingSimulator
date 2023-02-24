using System;
using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;

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
    public OnJoinedRoom OnJoinedRoom;
    public FinStatSync sync;
    public FinishStatistic FinishStatistic;
    public GameObject finPivot;
    public bool hvatit;


    // переменные для изменения управления

    public float mnojitel;
    public float mnojitel2;
    public float MaxSpeedFront;
    public float SpeedForChangeVilosityX;
    public bool MaxSpeedForword;
    public float MaxVelocityForvard;


    private void FixedUpdate()
    {
        if (tormoz && !hvatit)
        {
            if(OnJoinedRoom.PlayerNum == 1)
            {
                sync.timeFirst = FinishStatistic.time;
            }
            else if (OnJoinedRoom.PlayerNum == 2)
            {
                sync.TimeSecond = FinishStatistic.time;
            }
            rb.isKinematic = true;
            hvatit = true;
            go = false;
        }
        else if (tormoz)
        {
            transform.position = Vector3.Lerp(transform.position, finPivot.transform.position, 0.04f);
        }

        else if (go)
        {
            Z = Camera.localRotation.z;
            _x = Camera.localRotation.x;

            if (Camera.localRotation.w > 0)
            {
                rb.velocity = new Vector3(Camera.localRotation.z * rb.velocity.z * mnojitel * rb.velocity.z, rb.velocity.y, rb.velocity.z);

                if (rb.velocity.x >= SpeedForChangeVilosityX)
                {

                    rb.velocity = new Vector3(Camera.localRotation.z * rb.velocity.z * mnojitel2 * rb.velocity.z , rb.velocity.y, rb.velocity.z);

                }
                if (rb.velocity.x >= MaxSpeedFront)
                {
                    
                    rb.velocity = new Vector3(MaxSpeedFront, rb.velocity.y, rb.velocity.z);
                    
                }
                if (rb.velocity.z < -MaxVelocityForvard && MaxSpeedForword)
                {
                    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -MaxVelocityForvard);
                }
               // ski.transform.localRotation = new Quaternion(ski.transform.localRotation.x, -Camera.localRotation.z, ski.transform.localRotation.z, ski.transform.localRotation.w);
            }
            if (Camera.localRotation.w < 0)
            {
                rb.velocity = new Vector3(-Camera.localRotation.z * rb.velocity.z * mnojitel * rb.velocity.z, rb.velocity.y, rb.velocity.z);

                if (rb.velocity.x >= SpeedForChangeVilosityX)
                {

                    rb.velocity = new Vector3(-Camera.localRotation.z * rb.velocity.z * mnojitel2 * rb.velocity.z, rb.velocity.y, rb.velocity.z);

                }
                if (rb.velocity.x >= MaxSpeedFront)
                {
                    
                    rb.velocity = new Vector3(MaxSpeedFront, rb.velocity.y, rb.velocity.z);
                    
                }
                if (rb.velocity.z < -MaxVelocityForvard && MaxSpeedForword)
                {
                    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -MaxVelocityForvard);
                }
                //  ski.transform.localRotation = new Quaternion(ski.transform.localRotation.x, Camera.localRotation.z, ski.transform.localRotation.z, ski.transform.localRotation.w);
                // rb.velocity = new Vector3( -Camera.localRotation.z * rb.velocity.z * 5 * rb.velocity.z / 50, rb.velocity.y, rb.velocity.x);
                // ski.transform.localRotation = new Quaternion(ski.transform.localRotation.x, Camera.localRotation.z, ski.transform.localRotation.z, ski.transform.localRotation.w);
            }

            //if (_x > _q)
            //{
            //    // Player.addForce()
            //}
            //else if (_x < _q)
            //{
            //    rb.drag = _x / 1.2f;
            //}

            rb.drag = Math.Abs(Camera.localRotation.z) / 3f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "FinCol")
        {
            tormoz = true;
            finPivot = other.gameObject.GetComponent<FinishColision>().finishPivots[OnJoinedRoom.PlayerNum - 1];
        }
    }

}
