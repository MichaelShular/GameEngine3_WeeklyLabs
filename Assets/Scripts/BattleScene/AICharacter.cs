using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICharacter : ICharacter
{
    private enum AITypeOfStates { attack, heal, playerStunned};

    private AITypeOfStates CurrentState = 0;
    public override void TakeTurn(Encounter encounter)
    {
        if (encounter.player.incapacitated)
        {
            CurrentState = AITypeOfStates.playerStunned;
        }
        else if (encounter.enemy.health < 5)
        {
            CurrentState = AITypeOfStates.heal;
        }
        else
        {
            CurrentState = AITypeOfStates.attack;
        }


        switch (CurrentState)
        {
            case (AITypeOfStates)0:
                UseAbilty(percentOfAbility(50, 51, 75), this, encounter.player);
                break;
            case (AITypeOfStates)1:
                UseAbilty(percentOfAbility(20, 70, 85), this, encounter.player);
                break;
            case (AITypeOfStates)2:
                UseAbilty(percentOfAbility(60, 70, 100), this, encounter.player);
                break;
            default:
                break;
        }

        //Debug.Log("AI Turn");
    }

    private int percentOfAbility(int rangeForSlot0, int rangeForSlot1, int rangeForSlot2)
    {
        int abilityToUse = Random.Range(0, 100);
        
        if(abilityToUse < rangeForSlot0)
        {
            abilityToUse = 0;
        }
        else if(abilityToUse >= rangeForSlot0 && abilityToUse < rangeForSlot1)
        {
            abilityToUse = 1;
        }
        else if (abilityToUse >= rangeForSlot1 && abilityToUse < rangeForSlot2)
        {
            abilityToUse = 2;
        }
        else
        {
            abilityToUse = 3;
        }
        return abilityToUse;
    }

}
