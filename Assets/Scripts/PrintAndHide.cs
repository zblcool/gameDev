using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i;
    private int a;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        a = Random.Range(200, 250);
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i == a)
        {
            rend.enabled = false;
        }
        Debug.Log(gameObject.name + ":" + i);
        i++;
    }
}
