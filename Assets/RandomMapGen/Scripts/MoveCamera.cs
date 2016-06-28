using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	public float speed = 4f;

	private Vector3 startPos;
	private bool moving;

	void FixedUpdate() {
		if (Input.GetMouseButtonDown(1)) {
			startPos = Input.mousePosition;
			moving = true;
		}

		if (Input.GetMouseButtonUp(1) && moving) {
			moving = false;
		}

		if (moving) {
			Vector3 position = Camera.main.ScreenToViewportPoint (Input.mousePosition - startPos);
			Vector3 move = new Vector3 (position.x * speed, position.y * speed, 0);

			transform.Translate (move, Space.Self);
		}
	}	
}
