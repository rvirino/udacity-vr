using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeTrigger : MonoBehaviour {
	// Reference to the Google VR object in the scene
	private GvrViewer viewer;

	// Initializing animator object of Animator type
	Animator animator;
	// Use this for initialization
	void Start () {
		// animator object receive the Animator component
		animator = GetComponent<Animator>();

		// Locate the GvrViewer instance
		viewer = (GvrViewer)FindObjectOfType(typeof(GvrViewer));
		if (viewer == null) {
			Debug.LogError("No GvrViewer found. Please drag the GvrViewerMain prefab into the scene.");
			return;
		}
	}
	
	// Update is called once per frame
	void Update () {
		// If the viewer pressed the cardboard button, then RotateGlobe trigger is actived
		if (viewer.Triggered) {
			animator.SetTrigger("RotateGlobe");
		}
	}
}
