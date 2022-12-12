using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public int dieNum = 0;
    public int power = 0;
    public int turnNum = 0;
    public bool run = false;

    public GameObject[] lights;

    [SerializeField]
    private float moveTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) || run == true)
        {
            StartCoroutine(Activelights());
        }

    }

    private IEnumerator Activelights()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            if (i < turnNum)
            {
                lights[i].SetActive(true);
                yield return new WaitForSeconds(moveTime);

            }
            else
            {
                lights[i].SetActive(false);
            }

            if (turnNum == 4)
            {
                turnNum = 7;
            }
        } 
    }

    public void LightsUpdate()
    {
        run = true;
    }

    public void TurnIncrease()
    {
        turnNum += dieNum;
    }
    public void TurnDecrease()
    {
        turnNum -= dieNum;
    }
    public int RollDice()
    {
        dieNum = Random.Range(1, 7);
        return dieNum;
    }
    public void PowerIncrease()
    {
        power += dieNum;
    }
    public void PowerDecrease()
    {
        power -= dieNum;
    }
}
