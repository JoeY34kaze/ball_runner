using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class SmoothFollow : MonoBehaviour
	{

		// The target we are following
		[SerializeField]
		private Transform target;
		// The distance in the x-z plane to the target
		[SerializeField]
		private float _z = 10.0f;
		[SerializeField]
		private float k=1.5f;


		// Update is called once per frame
		void LateUpdate()
		{
			// Early out if we don't have a target
			if (!target)
				return;


			//transform.position = target.position;//tam k player
			transform.position=new Vector3(0,0,target.position.z-_z);// za playerjem
			Vector3 v=new Vector3(target.position.x,target.position.y,0);//za rotacijo kamere (kot na xy osi)
			v *= k;
			transform.position += v;

			//note: tole kodo se da (bo potrebno) popravt da je kamera fiksno za playerjem če bo player skakov recimo ker bo kamero odfukal v vesolje




			// Always look at the target
			transform.LookAt(target);
		}
	}
}