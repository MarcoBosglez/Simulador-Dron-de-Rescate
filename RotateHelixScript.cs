using UnityEngine;
using System.Collections;

public class RotateHelixScript : MonoBehaviour {

    public Transform helix1;
    public Transform helix2;
    public Transform helix3;
    public Transform helix4;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        helix1.Rotate(0, Time.deltaTime * 2000, 0, Space.World);
        helix2.Rotate(0, Time.deltaTime * 2005, 0, Space.World);
        helix3.Rotate(0, Time.deltaTime * 2020, 0, Space.World);
        helix4.Rotate(0, Time.deltaTime * 2010, 0, Space.World);
    }


}
