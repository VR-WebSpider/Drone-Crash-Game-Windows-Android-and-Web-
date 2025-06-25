using System.Runtime.CompilerServices;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private LogicScript logic;
    private Collider2D box;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collisions)
    {

        if (collisions.gameObject.layer == 3)

        {
            logic.addScore(1);
        }

    }


}
