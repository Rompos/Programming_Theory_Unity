using UnityEngine;

public class Rotate : MonoBehaviour {

    public float rotateSpeed = 35f; //speed at which object rotates
    private Vector3 rotatePoint = new Vector3(0, 0, -2); //point that the object rotates around
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(rotatePoint, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
