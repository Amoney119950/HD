using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Assistant : MonoBehaviour
{
    [SerializeField] private TextWriter textWriter;
    private Text messageText;

    private void Awake()
    {
        messageText = transform.Find("Message").Find("Discribtion").GetComponent<Text>();
    }

    private void Start()
    {
        textWriter.AddWriter(messageText, "Spiders are arachnids with eight legs instead of six and a body separated into two halves rather than three. " +
            "There are more than 46,700 species of spiders. " +
            "Spiders have an advanced understanding of silk. Except for size, spiders don't vary much as they mature. " +
            "The number and configuration of eyes, as well as the kind of web, play a big role in classifying species. " +
            "Black widow, tarantula, and wolf spider are some spiders to be aware of.", .1f, true);
    }
}
