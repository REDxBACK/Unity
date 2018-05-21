
using UnityEngine;

public class RopeScript : MonoBehaviour {

    public Rigidbody hook;

    public GameObject linkPrefab;

    public Weightscript weight;

    public int links = 10;


	// Use this for initialization
	void Start () {

        GenerateRope();

		
	}

    void GenerateRope()
    {
        Rigidbody previousRB = hook;
        for (int i = 0; i < links; i++)
        {
            GameObject link =  Instantiate(linkPrefab, transform);
            HingeJoint joint = link.GetComponent<HingeJoint>();
            joint.connectedBody = previousRB;

            if (i < links - 1)
            {

                previousRB = link.GetComponent<Rigidbody>();

            }else
            {
                weight.ConnectedRopeEnd(link.GetComponent<Rigidbody>());
            }
 
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
