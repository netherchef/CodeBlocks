using UnityEngine;

public enum ActivatorType { OnThenOff, OffThenOn }

public class ActivatorTrigger : MonoBehaviour
{
	// Activator Trigger Variables

	[Header ("Activator Type:")]
	public ActivatorType activatorType;

	[Header ("Target Tag:")]
	public string targetTag;

	[Header ("Target:")]
	public GameObject[] objects;

	private void OnTriggerEnter2D (Collider2D collision)
	{
		if (collision.CompareTag (targetTag))
		{
			Select_Entry_Action ();
		}
	}

	private void OnTriggerExit2D (Collider2D collision)
	{
		if (collision.CompareTag (targetTag))
		{
			Select_Exit_Action ();
		}
	}

	void Select_Entry_Action ()
	{
		if (activatorType == ActivatorType.OnThenOff) OnOff (true);
		else if (activatorType == ActivatorType.OffThenOn) OnOff (false);
	}

	void Select_Exit_Action ()
	{
		if (activatorType == ActivatorType.OnThenOff) OnOff (false);
		else if (activatorType == ActivatorType.OffThenOn) OnOff (true);
	}

	void OnOff (bool state)
	{
		for (int e = 0; e < objects.Length; e++)
		{
			objects[e].SetActive (state);
		}
	}
}
