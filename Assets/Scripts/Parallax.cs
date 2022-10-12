using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

	private float length, startpos;
	public GameObject cam;
	public float parallaxEffect;

	void Start()
	{
		startpos = transform.position.y;
		length = GetComponent<SpriteRenderer>().bounds.size.y;
	}

	void FixedUpdate()
	{
		float temp = (cam.transform.position.y * (1 - parallaxEffect));
		float dist = (cam.transform.position.y * parallaxEffect);
		
		transform.position = new Vector3(transform.position.x, startpos + dist, transform.position.z);
		if (temp > startpos + length) startpos += length;
		else if (temp < startpos - length) startpos -= length;

		// Auto move the background -- may delete this
		cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + 0.04f , cam.transform.position.z);
	}
}
