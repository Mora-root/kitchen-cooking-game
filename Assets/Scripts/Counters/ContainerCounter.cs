using UnityEngine;
using System;

public class ContainerCounter : BaseCounter
{

    public event EventHandler OnPlayerGrabbedObject;

    [SerializeField] private KitchenObjectSO kitchenObjectsSO;

    public override void Interact(Player player)
    {
        if (!player.HasKitchenObject())
        {
            // Player not carrying anything
            KitchenObject.SpawnKitchenObject(kitchenObjectsSO, player);
            

            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
    }

}
