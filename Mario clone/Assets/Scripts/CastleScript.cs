using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            NewMethod();
        }
    }

    private static void NewMethod()
    {
        Application.LoadLevel("Win");
    }
}
