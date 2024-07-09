using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public WarCharacter character;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image artworkImage;

    public TextMeshProUGUI upgradeLevetText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI rangeText;
    public TextMeshProUGUI durabilityText;


    private void Start()
    {
        DisplayCardStats();
    }

    public void DisplayCardStats()
    {
        if(character != null)
        {
            if(character.name != null)
                nameText.text = character.name;
            if(character.description!=null)
                descriptionText.text = character.description;
            if(character.artwork!=null)
                artworkImage.sprite=character.artwork;
            if(character.upgradeLevel!=0)
                upgradeLevetText.text=character.upgradeLevel.ToString();
            if(character.attack!=0)
                attackText.text=character.attack.ToString();
            if(character.health!=0)
                healthText.text=character.health.ToString();
            if(character.range!=0)
                rangeText.text=character.range.ToString();
            if(character.durabilty!=0)
                durabilityText.text= character.durabilty.ToString();
        }
    }
}
