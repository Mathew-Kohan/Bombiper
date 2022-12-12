using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text dieText;
    public Text powerText;
    public Button rollButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOn()
    {
        GameManager.Instance.TurnIncrease();
        GameManager.Instance.LightsUpdate();
    }

    public void RollaDie()
    {
        GameManager.Instance.run = false;

        GameManager.Instance.RollDice();
        dieText.text = GameManager.Instance.RollDice().ToString();
        rollButton.enabled = false;
    }

    public void Gainpower()
    {
        GameManager.Instance.PowerIncrease();
        powerText.text = GameManager.Instance.power.ToString();
    }
}
