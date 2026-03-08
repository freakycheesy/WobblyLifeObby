using ModWobblyLife;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        other?.GetComponent<ModPlayerCharacter>()?.Kill();
    }
}
