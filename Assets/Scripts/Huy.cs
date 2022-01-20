using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Huy : MonoBehaviour
{

    public GameObject Cube;
    public Sprite[] sprite;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(gg());
        //Cube.tra
        /*object a = Cube.GetComponent<Image>.image = sprite;*/
        //Cube.GetComponent<Image>().sprite = sprite;

    }

    private IEnumerator gg()
    {
        do
        {
            yield return new WaitForSeconds(1.5f);
            Cube.GetComponent<Image>().sprite = sprite[Random.Range(0, sprite.Length)];


        } while (true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
