using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EncounterUI : MonoBehaviour
{
    [SerializeField] GameObject abilitiesPanel;
    // Start is called before the first frame update
    [SerializeField] TMPro.TextMeshProUGUI encounterTextBox;

    [SerializeField] float timeBetweenCharacters;
    void Start()
    {
        StartCoroutine(AnimateTextCoroutine("You have encounter a battle", timeBetweenCharacters));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AnimateTextCoroutine(string message, float secPerCharacter)
    {
        abilitiesPanel.SetActive(false);

        encounterTextBox.text = "";

        for (int i = 0; i < message.Length; i++)
        {
            encounterTextBox.text += message[i];
            yield return new WaitForSeconds(secPerCharacter);
        }

        abilitiesPanel.SetActive(true);
    }
}
