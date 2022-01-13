using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeError : MonoBehaviour
{
	void Start()
	{
		int age = 37;
	}

	void Update()
	{
		// print("You are " + age);
	}

}
