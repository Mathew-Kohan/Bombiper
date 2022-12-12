using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text dieText;
    public Text powerText;
    public Button rollButton;
    public Button lightsButton;
    public Button gainPowerButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        powerText.text = GameManager.Instance.power.ToString();
    }

    public void TurnOnLights()
    {
        GameManager.Instance.TurnIncrease();
        GameManager.Instance.LightsUpdate();
        lightsButton.interactable = false;
        gainPowerButton.interactable = false;

        rollButton.interactable = true;
    }

    public void RollaDie()
    {
        GameManager.Instance.run = false;

        GameManager.Instance.RollDice();
        dieText.text = GameManager.Instance.RollDice().ToString();
        rollButton.interactable = false;
        lightsButton.interactable = true;

        if (GameManager.Instance.powerTurn <= GameManager.Instance.turnNum)
        {
            gainPowerButton.interactable = true;
        }
    }

    public void Gainpower()
    {
        GameManager.Instance.PowerIncrease();
        gainPowerButton.interactable = false;
        lightsButton.interactable = false;
        rollButton.interactable = true;
    }
}
