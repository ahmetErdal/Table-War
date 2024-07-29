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
        //DisplayCardStats();
    }

    public void DisplayCardStats(WarCharacter warCharacter)
    {
        if (warCharacter.name != null)
            nameText.text = warCharacter.name;
        if (warCharacter.description != null)
            descriptionText.text = warCharacter.description;
        if (warCharacter.artwork != null)
            artworkImage.sprite = warCharacter.artwork;
        if (warCharacter.upgradeLevel != 0)
            upgradeLevetText.text ="Lvl:"+ warCharacter.upgradeLevel.ToString();
        if (warCharacter.attack != 0)
            attackText.text ="Attack:"+ warCharacter.attack.ToString();
        if (warCharacter.health != 0)
            healthText.text = "Health:"+warCharacter.health.ToString();
        if (warCharacter.range != 0)
            rangeText.text ="Range:"+ warCharacter.range.ToString();
        if (warCharacter.durabilty != 0)
            durabilityText.text = warCharacter.durabilty.ToString();
    }
}
