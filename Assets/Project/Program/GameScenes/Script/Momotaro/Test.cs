using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int test = 0;

    // Start is called before the first frame update
    void Start()
    {
        test = 100;

    }

    // Update is called once per frame
    void Update()
    {
        test += 1;
    }
}
