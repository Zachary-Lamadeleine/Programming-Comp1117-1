using UnityEngine;

public class GravityZone : Zone
{
    
    protected override void ApplyZoneEffect(Player player)
    {
        player.ApplyGravityFlip(-1f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Ensure that the Player is in the trigger
        if (collision.TryGetComponent(out Player player))
        {
            player.ApplyGravityFlip(1f);
        }
    }

}
