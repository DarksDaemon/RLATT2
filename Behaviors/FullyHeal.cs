﻿using RLATT2.Core;
using RLATT2.Interfaces;
using RLATT2.Systems;

namespace RLATT2.Behaviors
{
   public class FullyHeal : IBehavior
   {
      public bool Act( Monster monster, CommandSystem commandSystem )
      {
         if ( monster.Health < monster.MaxHealth )
         {
            int healthToRecover = monster.MaxHealth - monster.Health;
            monster.Health = monster.MaxHealth;
            Game.MessageLog.Add( $"{monster.Name} catches his breath and recovers {healthToRecover} health" );    
            return true;
         }
         return false;
      }
   }
}
