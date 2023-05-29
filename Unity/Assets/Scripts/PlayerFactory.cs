using UnityEngine;

public class PlayerFactory
{
    private int _lastId;

    public Player CreateNewPlayer()
    {
        var playerId = _lastId++;
        var playerObject = new GameObject($"Player{playerId}");
        var player = playerObject.AddComponent<Player>();
        player.Id = playerId;

        return player;
    }
}