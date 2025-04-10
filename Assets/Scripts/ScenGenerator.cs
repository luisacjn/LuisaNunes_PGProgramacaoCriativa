using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenGenerator : MonoBehaviour
{
    public GameObject[] ObjtoGenerate;

    public bool[,] posOcupadas = new bool[30, 30];

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<30; i += 3)
        {
            for (int j=0;j<30; j+= 3)
            {
                if (posOcupadas[i, j] == false)
                {


                    int n = Random.Range(0, ObjtoGenerate.Length);


                    Instantiate(ObjtoGenerate[n], new Vector3(i, j, 0), Quaternion.identity);
                }

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
