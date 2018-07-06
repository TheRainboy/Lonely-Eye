using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadSign : MonoBehaviour
{

    public GameObject UIobject;
    public GameObject player;

    private void Start()
    {
        UIobject.SetActive(false);
    }

    private void Update()
    {
        StartCoroutine(WaitForSec());
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (player.gameObject.tag == "Player")
        {
            UIobject.SetActive(true);

        }

    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(10f);
        Destroy(UIobject);
        Destroy(gameObject);
    }
}
    
