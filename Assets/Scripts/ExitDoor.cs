using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    private Animator door;

    private void Awake()
    {
        door = GetComponent<Animator>();
    }

    public void ChangeEnergyStatus()
    {
        door.SetBool("Energized", !door.GetBool("Energized"));
    }
}
