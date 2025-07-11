using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        UiManager.instance.ShowPanelGameOver();
        base.Die();
    }
}
