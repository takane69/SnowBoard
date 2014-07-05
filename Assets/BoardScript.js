#pragma strict

var spd : float = 2.0;

function Start () {

}

function Update () {
	var hol : float = Input.GetAxis("Horizontal");											//水平入力
	var ver : float = Input.GetAxis("Vertical");											//垂直入力
	Debug.Log(hol);
	var velocity : Vector3 = Vector3(0, 0, ver);											//z方向の移動量
	transform.rotation.y += hol * Time.deltaTime;											//旋回
	velocity = transform.TransformDirection(velocity);										//z方向のベクトル変換（ワールド）
	transform.localPosition += velocity * spd * Time.deltaTime;									//前方向に加速
}