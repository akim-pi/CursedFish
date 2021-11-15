using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonDestroyer : MonoBehaviour
{
    public KeyCode keyToDestroy;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(keyToDestroy))
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A was pressed");
        }
    }
}
