using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ModWobblyLife;

public class Sandbox : ModFreemodeGamemode {
    protected override void OnSpawnedPlayerController(ModPlayerController playerController) {
        base.OnSpawnedPlayerController(playerController);
        playerController.ServerSetSandboxUIEnabled(true);
    }
}