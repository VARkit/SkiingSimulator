using UnityEngine;
using UltimateXR.Avatar;
using UltimateXR.Core;
using UltimateXR.Locomotion;

public class TeleportingInStart : MonoBehaviour
{
    public UxrAvatar myAvatar;
    public Transform TeleportPoint;
    public Transform TransformParent;
    public Impulse Impulse;

    void Start()
    {
        myAvatar = UxrAvatar.LocalAvatar;
        Debug.Log(myAvatar);
    }

    public void StartToPoint()
    {
        Quaternion Coordinates = TeleportPoint.rotation;
        UxrManager.Instance.TeleportLocalAvatar(TeleportPoint.transform.position, new Quaternion(Coordinates.x, Coordinates.y, Coordinates.z, Coordinates.w), UxrTranslationType.Fade);
        myAvatar.transform.parent = TransformParent;
        Impulse.DoImpulse();
    }
}
