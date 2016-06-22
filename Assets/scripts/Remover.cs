using UnityEngine;
using System.Collections;

public class Remover : MonoBehaviour {
	void OnTriggerExit(Collider e){
		Destroy (e.gameObject);
		Debug.Log("asdasd");
	}
}
