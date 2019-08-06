using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TriggerType { Entry, Exit, Both }

public class TriggerHandler : MonoBehaviour
{
    // Trigger Handler Variables

    [Header ("Trigger Phase:")]
    public TriggerType targetPhase;

    [Header ("Target:")]
    public string targetTag;

    [Header ("Hooks:")]
    public bool triggered;

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (targetPhase == TriggerType.Entry || targetPhase == TriggerType.Both)
        {
            if (collision.CompareTag (targetTag))
            {
                triggered = true;
            }
        }
    }

    private void OnTriggerExit2D (Collider2D collision)
    {
        if (targetPhase == TriggerType.Exit || targetPhase == TriggerType.Both)
        {
            if (collision.CompareTag (targetTag))
            {
                triggered = false;
            }
        }
    }
}
