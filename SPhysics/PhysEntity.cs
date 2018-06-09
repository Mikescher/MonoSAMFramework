using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoSAMFramework.Portable.GameMath.Geometry;
using MonoSAMFramework.Portable.Screens;
using MonoSAMFramework.Portable.Screens.Entities;

namespace MonoSAMFramework.Portable.SPhysics
{
	public abstract class PhysEntity : GameEntity
	{
		protected PhysEntity(GameScreen scrn, int order) : base(scrn, order)
		{
			//
		}
	}
}
