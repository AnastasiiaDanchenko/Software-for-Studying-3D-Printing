using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGeneration : MonoBehaviour
{
    public Transform spawnPos;
	public GameObject spawnee;

	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
		}
	}
}
