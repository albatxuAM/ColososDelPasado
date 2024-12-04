namespace Unity.FPS.Gameplay
{
    public class ResourcePickup : Pickup
    {
        protected override void OnPicked(PlayerCharacterController byPlayer)
        {
            //PlayPickupFeedback();
            Destroy(gameObject);
        }
    }
}
