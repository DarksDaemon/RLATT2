using RLATT2.Core;
using RLATT2.Systems;

namespace RLATT2.Interfaces
{
   public interface IBehavior
   {
      bool Act( Monster monster, CommandSystem commandSystem );
   }
}
