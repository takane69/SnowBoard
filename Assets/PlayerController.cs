using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	Rigidbody _rigidbody;
	Transform _transform;
	
	void Start ()
	{
		_rigidbody = rigidbody;
		_transform = transform;
	}

	void Update ()
	{
		Quaternion q = new Quaternion(_transform.rotation.x ,
		                              _transform.rotation.y + Input.GetAxis("Horizontal") * Time.deltaTime ,
		                              _transform.rotation.z , _transform.rotation.w);

		_transform.rotation = q;

//		_rigidbody.velocity = _rigidbody.velocity + _transform.forward;
	}

	void FixedUpdate ()
	{
		float f = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.z).magnitude;

		_rigidbody.velocity = new Vector3(_transform.forward.x * f ,
		                                  _rigidbody.velocity.y ,
		                                  _transform.forward.z * f );
	}
}
