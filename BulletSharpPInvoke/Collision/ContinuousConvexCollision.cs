using static BulletSharp.UnsafeNativeMethods;

namespace BulletSharp
{
	public class ContinuousConvexCollision : ConvexCast
	{
		public ContinuousConvexCollision(ConvexShape shapeA, ConvexShape shapeB,
			VoronoiSimplexSolver simplexSolver, ConvexPenetrationDepthSolver penetrationDepthSolver)
			: base(btContinuousConvexCollision_new(shapeA.Native, shapeB.Native,
				simplexSolver._native, penetrationDepthSolver._native))
		{
		}

		public ContinuousConvexCollision(ConvexShape shapeA, StaticPlaneShape plane)
			: base(btContinuousConvexCollision_new2(shapeA.Native, plane.Native))
		{
		}
	}
}
