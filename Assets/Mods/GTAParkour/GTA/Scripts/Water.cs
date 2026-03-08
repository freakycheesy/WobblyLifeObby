using ModWobblyLife;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject splash;
    private void OnTriggerEnter(Collider other) {
        var instance = Instantiate(splash, other.transform.position, Quaternion.identity);
        instance.transform.localScale = other.bounds.size;
        StartCoroutine(Kill(other.GetComponentInParent<ModPlayerCharacter>()));
    }
    IEnumerator Kill(ModPlayerCharacter character) {
        if (!character)
            yield return null;
        character.gameObject.SetActive(false);
        yield return new WaitForSeconds(2);
        character.gameObject.SetActive(true);
        character.Kill();
    }
}
