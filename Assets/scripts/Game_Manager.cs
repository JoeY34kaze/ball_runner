using UnityEngine;
using System.Collections;

public class Game_Manager : MonoBehaviour {

	public float spawn_per_second = 1.0f;
	public GameObject furgl;

	private move_hurdle obsticles_manager;
	public float starting_speed=1.0f;
	public float acceleration = 1.001f;
	public float current_speed = 1.0f;


	// Use this for initialization
	void Start () {
		StartCoroutine (spawner());
		current_speed = starting_speed;
		StartCoroutine (obsticles_movement ());
	}

	IEnumerator spawner(){
		while (true) {
			spawn_per_second *= 1.01f;
			Vector2 f = Random.insideUnitCircle;
			Vector3 spawn_position = new Vector3 (f.x,f.y, 20);//random xyz
			Quaternion spawn_rotation= Quaternion.identity;
			GameObject temp=(GameObject)Instantiate (furgl, spawn_position, spawn_rotation);
			temp.transform.parent = transform;

			yield return new WaitForSeconds (1.0f / spawn_per_second);
		}
	}

	IEnumerator obsticles_movement(){
		current_speed *= acceleration;
		Component[] a;
		a = GetComponentsInChildren<move_hurdle> ();
		foreach(move_hurdle m in a){
			m.speed = current_speed;
		}
		yield return new WaitForSeconds (5);
	}
	

}
