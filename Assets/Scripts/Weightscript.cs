
using UnityEngine;

public class Weightscript : MonoBehaviour
{
    public float distanceFromChainedEnd = .6f;

    public void ConnectedRopeEnd(Rigidbody endRB)
    {
        HingeJoint joint = gameObject.AddComponent<HingeJoint>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = endRB;
        joint.anchor = Vector3.zero;
        joint.connectedAnchor = new Vector3(0f, -distanceFromChainedEnd);

    }

}
