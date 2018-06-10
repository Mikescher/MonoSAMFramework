
using MonoSAMFramework.Portable.BatchRenderer;
using MonoSAMFramework.Portable.GameMath.Geometry;
using MonoSAMFramework.Portable.Input;
using MonoSAMFramework.Portable.Screens;

namespace MonoSAMFramework.Portable.SPhysics
{
	public class TiledPhysicsMap : ISPhysicsMap
	{
		private readonly DPoint _offset;
		private readonly DSize _size;
		private readonly int _tileCountX;
		private readonly int _tileCountY;
		private readonly float _tileWidth;
		private readonly float _tileHeight;



		public TiledPhysicsMap(DPoint offset, DSize mapsize, int tileCountX, int tileCountY)
		{
			_offset     = offset;
			_size       = mapsize;
			_tileCountX = tileCountX;
			_tileCountY = tileCountY;
			_tileWidth  = mapsize.Width  / (tileCountX * 1f);
			_tileHeight = mapsize.Height / (tileCountY * 1f);
		}

		public void Update(SAMTime gameTime, InputState istate)
		{
			//
		}

		public void RegisterEntity(PhysEntity e)
		{
			//
		}
		
		void DrawDebug(IBatchRenderer sbatch)
		{

		}
	}
}
