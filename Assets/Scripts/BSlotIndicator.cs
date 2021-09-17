using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSlotIndicator : MonoBehaviour
{
    /* Public */

    /* Private */
    // The light indicator to use (which is the one this script is attached to.
    private MeshRenderer lightIndicator;
    // The Material to use when all batteries have been placed on all slots.
    [SerializeField] private Material allBatteriesPlacedMaterial;
    // The Material to use when no batteries have been placed on any slot.
    [SerializeField] private Material noBatteriesPlacedMaterial;

    private void Awake()
    {
        lightIndicator = GetComponent<MeshRenderer>();
    }

    public void AllBatteriesPlaced()
    {
        lightIndicator.material = allBatteriesPlacedMaterial;
    }

    public void NoBatteriesPlaced()
    {
        lightIndicator.material = noBatteriesPlacedMaterial;
    }
}
