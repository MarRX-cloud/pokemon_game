using GameOOP_Project.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP_Project.BattleGround
{
    public class BattleService
    {
        public void charBattle(Trainer player, PokeChar char1)
        {
            PokeChar? playerPokeChar; // nullable pokechar
            for (int i = 0; i < player.Team.Count; i++) // for all characters
            {
                if (player.Team[i].CurrentStats.HP > 0) // if HP is greater than 0 and index is smaller, then its selected.
                {
                    playerPokeChar = player.Team[i];
                    break;
                }
            }

            bool inFight = true && (playerPokeChar != null);
            while (inFight)
            {
                // player can either leave fight, select attack, use item or catch char
            }


        }
    }
}
