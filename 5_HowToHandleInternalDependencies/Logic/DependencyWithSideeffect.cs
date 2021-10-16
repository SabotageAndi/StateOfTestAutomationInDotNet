using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IDependencyWithSideeffect
    {
        void DoingSomethingWithASideEffect();
    }

    public class DependencyWithSideeffect : IDependencyWithSideeffect
    {
        public void DoingSomethingWithASideEffect()
        {
            throw new NotImplementedException();
        }
    }
}
