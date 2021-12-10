using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : ICharacter
{
    [SerializeField] Encounter myEnounter;
    public Animator charactersAnimation;
    public void CastAbility(int slot)
    {
        UseAbilty(slot, this, myEnounter.enemy);
        charactersAnimation.SetInteger("AnimationState", slot);
    }
    public override void TakeTurn(Encounter encounter)
    {
        myEnounter = encounter;
    }

}
