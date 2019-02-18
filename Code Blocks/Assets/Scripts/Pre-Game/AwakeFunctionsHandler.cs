using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeFunctionsHandler : MonoBehaviour {

	// Variables

	public int targetFunctionCount;
	int execeutedFunctions;

	// Enumerators

	IEnumerator awakeFunctions;

	// Debug

	public bool debug;

	#region Awake Functions ____________________________________________________

	private void Awake () {
		awakeFunctions = AwakeFunctions ();
		StartCoroutine (awakeFunctions);
	}

	IEnumerator AwakeFunctions () {

		EnumeratorTracker.AddEnumFlag ();

		// All functions that must run on Awake go here.

		yield return null;

		if (debug) CheckFunctionCount ();

		EnumeratorTracker.RemoveEnumFlag ();
	}

	#endregion

	#region Awake Function Count Check _________________________________________

	bool FunctionCountsMatch () {
		return execeutedFunctions == targetFunctionCount;
	}

	void CheckFunctionCount () {
		if (!FunctionCountsMatch ()) WarnCountMismatch ();
	}

	void WarnCountMismatch () {
		Debug.LogWarning ("Awake function count = " + targetFunctionCount + " | Executed functions = " + execeutedFunctions);
	}

	#endregion
}
