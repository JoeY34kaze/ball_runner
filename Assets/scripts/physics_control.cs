using UnityEngine;
using System.Collections;

public class physics_control : MonoBehaviour {
	public GameObject player;
	public float k = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		if (!player) {
			return;
		}
		Physics.gravity = (new Vector3(-player.transform.position.x,-player.transform.position.y,0))*k;
	}
}
