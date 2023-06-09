﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

namespace Slicer2D.Demo {

	public class DemoFollowMouse : MonoBehaviour {

		void Update () {
			float z = transform.position.z;

			Vector3 pos = GetMousePosition().ToVector2();
			pos.z = z;

			transform.position = pos;
		}

		public static Vector2D GetMousePosition() {
			return(new Vector2D (Camera.main.ScreenToWorldPoint (UnityEngine.Input.mousePosition)));
		}
	}
}