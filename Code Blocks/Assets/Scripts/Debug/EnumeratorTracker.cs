using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumeratorTracker : MonoBehaviour {

	public static int runningEnums;
	public int runningEnumerators;

	private void Update () {
		UpdateEnumDisplay ();
	}

	#region Enumerator Count Display ___________________________________________

	void UpdateEnumDisplay () {
		runningEnumerators = runningEnums;
	}

	#endregion

	#region Enumerator Count Changers __________________________________________

	public static void AddEnumFlag () {
		runningEnums++;
	}

	public static void RemoveEnumFlag () {
		runningEnums--;
	}

	#endregion
}
