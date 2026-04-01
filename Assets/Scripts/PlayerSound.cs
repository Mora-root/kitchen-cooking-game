using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class PlayerSound : MonoBehaviour
{

    private Player player;

    private float footStepTimer;
    private float footStepTimerMax = 0.15f;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        footStepTimer -= Time.deltaTime;
        if (footStepTimer < 0f)
        {
            footStepTimer = footStepTimerMax;

            if (player.IsWalking())
            {
                float volume = 1.5f;
                SoundManager.Instance.PlayFootstepsSound(player.transform.position, volume);
            }
        }
    }
}
