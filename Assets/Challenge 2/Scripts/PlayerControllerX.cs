using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public bool canSend = true; // Set to true at start of the game

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSend == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSend = false;
            StartCoroutine(DogCooldownRoutine());
        }
    }

    IEnumerator DogCooldownRoutine()
    {
        yield return new WaitForSeconds(1.5f); // Wait for 2 seconds, then execute following lines of code
        canSend = true;
    }
}
