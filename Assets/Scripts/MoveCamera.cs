﻿// Credit to damien_oconnell from http://forum.unity3d.com/threads/39513-Click-drag-camera-movement
// for using the mouse displacement for calculating the amount of camera movement .


using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour 
{
	
	
	public float turnSpeed = 4.0f;		// Speed of camera turning when mouse moves in along an axis
	public float zoomSpeed = 4.0f;		// Speed of the camera going back and forth
	
	private Vector3 mouseOrigin;	// Position of cursor when mouse dragging starts
	private bool isRotating;	// Is the camera being rotated?
	private bool isZooming;		// Is the camera zooming?
	
	//
	// UPDATE
	//
	
	void Update () 
	{
		// Get the left mouse button
		if(Input.GetMouseButtonDown(0))
		{
			// Get mouse origin
			mouseOrigin = Input.mousePosition;
			isRotating = true;
		}
		
		
		// Get the right mouse button
		if(Input.GetMouseButtonDown(1))
		{
			// Get mouse origin
			mouseOrigin = Input.mousePosition;
			isZooming = true;
		}
		
		// Disable movements on button release
		if (!Input.GetMouseButton(0)) isRotating=false;
		if (!Input.GetMouseButton(1)) isZooming=false;
		
		// Rotate camera along X and Y axis
		if (isRotating)
		{
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);
			
			transform.RotateAround(transform.position, transform.right, pos.y * turnSpeed);
			transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
		}
				
		
		// Move the camera linearly along Z axis
		if (isZooming)
		{
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);
			
			Vector3 move = pos.y * zoomSpeed * transform.forward; 
			transform.Translate(move, Space.World);
		}
	}
}