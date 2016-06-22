using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	//playerja bojo premikale sile ker je nekak physics based game
	[SerializeField] private float a=0.1f;
	[SerializeField] private float k=1.0f;
	public float rotation_speed=1.0f;
	Touch touch;
	int rot=0;

	// Use this for initialization
	void Start () {

	}

	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.touchCount > 0) {
			touch = Input.GetTouch (0);

			if (touch.position.x < Screen.width / 2) {
				rot = 1;
			} else if (touch.position.x > Screen.width / 2) {
				rot = -1;
			}
		} else {
			rot = 0;
		}


		transform.RotateAround (new Vector3 (0, 0, 0), Vector3.forward, rot*rotation_speed* Time.fixedDeltaTime);
	}

	void OnTriggerEnter(Collider e){
		if(e.gameObject.name.Equals("Furgl"))Destroy (gameObject);
	}
}
