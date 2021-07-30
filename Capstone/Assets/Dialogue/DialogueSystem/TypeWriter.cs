using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeWriter : MonoBehaviour
{

    [SerializeField] private float typewriterSpeed = 50f;

    public Coroutine Run(string texttoType, TMP_Text textLabel)
    {
        return StartCoroutine(TypeText(texttoType, textLabel));
    }

    private IEnumerator TypeText(string texttoType, TMP_Text textLabel)
    {
        textLabel.text = string.Empty;
        
        float t = 0;
        int charIndex = 0;

        while (charIndex < texttoType.Length)
        {
            t += Time.deltaTime * typewriterSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, texttoType.Length);

            textLabel.text = texttoType.Substring(0, charIndex);
            
            yield return null;
        }

        textLabel.text = texttoType;
    }
}
