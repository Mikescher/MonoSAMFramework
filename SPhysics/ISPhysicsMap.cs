using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoSAMFramework.Portable.Interfaces;

namespace MonoSAMFramework.Portable.SPhysics
{
	public interface ISPhysicsMap : ISAMUpdateable
	{
		void RegisterEntity(PhysEntity e);
	}
}
