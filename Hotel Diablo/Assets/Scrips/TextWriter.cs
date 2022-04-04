using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{
        private Text uiText;
        private string textToWrite;
        private int characterIndex;
        private float timePerCharacter;
        private float timer;
        private bool invisibleCharacters;

        public void AddWriter(Text uiText, string textToWrite, float timePerCharater, bool invisibleCharacters)
        {
            this.uiText = uiText;
            this.textToWrite = textToWrite;
            this.timePerCharacter = timePerCharater;
            this.invisibleCharacters = invisibleCharacters;
            characterIndex = 0;
        }

        private bool Update()
        {
           
                timer -= Time.deltaTime;
                while (timer <= 0f)
                {
                    timer += timePerCharacter;
                    characterIndex++;
                    string text = textToWrite.Substring(0, characterIndex);
                    if (invisibleCharacters)
                    {
                        text += "<color=#00000000>" + textToWrite.Substring(characterIndex) + "</color>";
                    }
                    uiText.text = text;
                    if (characterIndex >= textToWrite.Length)
                    {
                return true;
                    }
                }
        return false;
          
        }
}
