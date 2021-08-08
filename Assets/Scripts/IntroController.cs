using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UIElements;

public class IntroController : MonoBehaviour
{

	public static IntroController introController;
	public GameObject intro;
    public GameObject outro;
	public GameObject playerShip;

	[SerializeField] Transform from;
	[SerializeField] Transform to;
	float speed = 0.1f;

	bool outtro = false;
	void Start()
    {
		introController = this;
	}
	private void Update()
	{
		if (outtro == true)
		{
			playerShip.transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, Time.time * speed / 140);
			playerShip.transform.position = Vector3.Lerp(from.position, to.position, Time.time * speed / 140);

		}

	}

	void OnTriggerEnter(Collider other)
	{

		if (intro.tag == "Intro")
		{
			PlayerController.playerController.isControlEnabled = true;
			transform.gameObject.tag = "IntroEnd";

		}
		else if (outro.tag == "Outro")
		{
			PlayerController.playerController.isControlEnabled = false;
			outtro = true;
			
		}
	}
}
