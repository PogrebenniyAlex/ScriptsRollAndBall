using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;
    private Quaternion rotate;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
        rotate = transform.rotation;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
        transform.rotation = rotate;
	}
}
