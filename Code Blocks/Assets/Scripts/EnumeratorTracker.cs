using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumeratorTracker : MonoBehaviour {

	public static int runningEnums;
	public int runningEnumerators;

	private void Update () {
		runningEnumerators = runningEnums;
	}

	public static void AddEnumFlag () {
		runningEnums++;
	}

	public static void RemoveEnumFlag () {
		runningEnums--;
	}
}
