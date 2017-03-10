using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	
	public Transform target;
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.position = new Vector3(target.position.x,
												target.position.y,
												target.position.z - 5);
		transform.LookAt(target);
	}
}
