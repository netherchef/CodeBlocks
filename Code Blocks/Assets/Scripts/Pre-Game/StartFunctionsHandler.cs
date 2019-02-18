using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFunctionsHandler : MonoBehaviour {

	// Variables

	public int targetFunctionCount;
	int execeutedFunctions;

	// Enumerators

	IEnumerator startFunctions;

	// Debug

	public bool debug;

	#region Start Functions ____________________________________________________

	private void Start () {
		startFunctions = StartFunctions ();
		StartCoroutine (startFunctions);
	}

	IEnumerator StartFunctions () {

		EnumeratorTracker.AddEnumFlag ();

		// All functions that must run on Start go here.

		yield return null;

		if (debug) CheckFunctionCount ();

		EnumeratorTracker.RemoveEnumFlag ();
	}

	#endregion

	#region Start Function Count Check _________________________________________

	bool FunctionCountsMatch () {
		return execeutedFunctions == targetFunctionCount;
	}

	void CheckFunctionCount () {
		if (!FunctionCountsMatch ()) WarnCountMismatch ();
	}

	void WarnCountMismatch () {
		Debug.LogWarning ("Start function count = " + targetFunctionCount + " | Executed functions = " + execeutedFunctions);
	}

	#endregion
}
