using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public Transform _mesh;

	Rigidbody _rigidbody;
	Transform _transform;
	
	void Start ()
	{
		_rigidbody = rigidbody;
		_transform = transform;
	}

	void Update ()
	{
		float hAxis = Input.GetAxis("Horizontal");

		Quaternion q = new Quaternion(_transform.rotation.x ,
		                              _transform.rotation.y + hAxis * Time.deltaTime ,
		                              _transform.rotation.z , _transform.rotation.w);

		_transform.rotation = q;

		_mesh.localRotation = Quaternion.Euler(0, 0, hAxis * -10f);

//		_rigidbody.velocity = _rigidbody.velocity + _transform.forward;
//		_rigidbody.velocity += _transform.forward / 2;										//加速度を半分にした
//		Debug.Log(_rigidbody.velocity);
	}

/*
	void FixedUpdate ()
	{
		float f = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.z).magnitude;

		_rigidbody.velocity = new Vector3(_transform.forward.x * f ,
		                                  _rigidbody.velocity.y ,
		                                  _transform.forward.z * f );
	}
*/
}
