using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEyeColor : MonoBehaviour
{
    public Material[] MaterialstoGenerate;

    // Start is called before the first frame update
    void Start()
    {
        int n = Random.Range(0, MaterialstoGenerate.Length);

        GetComponent<Renderer>().material = MaterialstoGenerate[n];

    }

    // Update is called once per frame
    void Update()
    {

    }
}
