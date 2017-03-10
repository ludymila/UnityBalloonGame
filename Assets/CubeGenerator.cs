using UnityEngine;
using System.Collections;

public class CubeGenerator : MonoBehaviour {
	
	public Transform player;
	public Mesh sampleObject;
	
	int counter = 0;
	public Texture texture;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(counter%2==0)
		{
			GameObject newObj = new GameObject("box");
			MeshFilter newFilter = newObj.AddComponent<MeshFilter>();
			newObj.AddComponent<MeshRenderer>();
			newFilter.sharedMesh = sampleObject;
			//RigidBody things
			Rigidbody newBody = newObj.AddComponent<Rigidbody>();
				newObj.rigidbody.isKinematic = true;
				newObj.rigidbody.useGravity = false;
				newObj.rigidbody.mass = 1f;
				newObj.rigidbody.drag = 0f;
				newObj.rigidbody.angularDrag = 0.05f;
			//Collider things
			BoxCollider newCollider = newObj.AddComponent<BoxCollider>();
			//Position things
			Vector3 pPos = player.transform.position;
			float x = Random.Range(-30,30);
			float y = Random.Range(-30,30);
			float z = Random.Range(40,50);
			Vector3 newPos = new Vector3(pPos.x + x, pPos.y + y, pPos.z + z);
			
			newObj.renderer.material.mainTexture = texture;
			newObj.transform.position = newPos;
		}
		counter += 1;
	}
}
