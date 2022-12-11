using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int dieNum;
    
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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(Activelights());
        }

    }


    private IEnumerator Activelights()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            if (i < dieNum)
            {
                lights[i].SetActive(true);
            }
            else
            {
                lights[i].SetActive(false);
            }

            if (dieNum == 4)
            {
                dieNum = 7;
            }
            yield return new WaitForSeconds(moveTime);
        }
        
    }
}
