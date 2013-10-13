using System;
using System.Diagnostics;

namespace StructStrings {
	public class Tests {
		public static void TestStrings( string a, string b ) {
			var sa8 = ( String8 ) a;
			var sa16 = ( String16 ) a;
			var sa24 = ( String24 ) a;
			var sa32 = ( String32 ) a;

			var sb8 = ( String8 ) b;
			var sb16 = ( String16 ) b;
			var sb24 = ( String24 ) b;
			var sb32 = ( String32 ) b;

			Debug.Assert( sa8.ToString() == a );
			Debug.Assert( sa16.ToString() == a );
			Debug.Assert( sa24.ToString() == a, "Self-string fail", "Self-string fail: {0} != {0}", sb24, b );
			Debug.Assert( sa32.ToString() == a );

			Debug.Assert( sb8.CompareTo( sb8 ) == 0, "Self-eq fail", "Self-eq fail: {0} != {1}", sb8, b );
			Debug.Assert( sb16.CompareTo( sb16 ) == 0, "Self-eq fail", "Self-eq fail: {0} != {1}", sb16, b );
			Debug.Assert( sb24.CompareTo( sb24 ) == 0, "Self-eq fail", "Self-eq fail: {0} != {1}", sb24, b );
			Debug.Assert( sb32.CompareTo( sb32 ) == 0, "Self-eq fail", "Self-eq fail: {0} != {1}", sb32, b );

			Debug.Assert( Math.Sign( sa24.CompareTo( sb24 ) ) == Math.Sign( String.Compare( a, b, StringComparison.Ordinal ) ), "String-cmp fail", "String-cmp fail:\"{{{2}}}\"(\"{3}\") and \"{{{0}}}\"(\"{1}\")", sb24, b, sa24, a );
		}
	}
}
