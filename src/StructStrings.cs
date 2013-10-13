/*
 * Methods are manually inlined due to performance reasons. Don't touch.
*/
using System;
using System.Runtime.CompilerServices;
namespace StructStrings {
	/// <summary>
	/// Compact ascii string storage(8 chars max)
	/// </summary>
	public unsafe struct String8 : IComparable, IComparable<String8>, IEquatable<String8> {
		private ulong _1;
		
		#region Comparators : IComparable, IComparable<String8>, IEquatable<String8>, ==, !=, >, <,>=,<=
		public override bool Equals( object obj ) { return !ReferenceEquals( null, obj ) && ( obj is String8 && Equals( ( String8 ) obj ) ); }
		public override int GetHashCode() { return _1.GetHashCode(); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator >( String8 a, String8 b ) { return a._1 > b._1; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator <( String8 a, String8 b ) { return a._1 < b._1; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator <=( String8 a, String8 b ) { return a._1 <= b._1; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator >=( String8 a, String8 b ) { return a._1 >= b._1; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator ==( String8 a, String8 b ) { return a._1 == b._1; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator !=( String8 a, String8 b ) { return a._1 != b._1; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public bool Equals( String8 other ) { return this._1 == other._1; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static int Compare( String8 a, String8 b ) { return a._1.CompareTo( b._1 ); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public int CompareTo( object obj ) { return _1.CompareTo( ( ( String8 ) obj )._1 ); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public int CompareTo( String8 other ) { return _1.CompareTo( other._1 ); }
		#endregion
		#region String conversions
		public static explicit operator String8( string s ) { return FromString( s ); }
		public static String8 FromString( string s ) {
			fixed ( char* rc = s ) {
				String8 ret;
				Helper.FillAsciiBytes( ( byte* ) &ret, rc, s.Length, sizeof( String8 ) );
				return ret;
			}
		}
		public override string ToString() {fixed ( String8* r = &this )return Helper.ToString( ( byte* ) r, sizeof( String8 ) );}
		#endregion
	}
	/// <summary>
	/// Compact ascii string storage(16 chars max)
	/// </summary>
	public unsafe struct String16 : IComparable, IComparable<String16>, IEquatable<String16> {
		private ulong _2;
		private ulong _1;

		#region Comparators : IComparable, IComparable<String16>, IEquatable<String16>, ==, !=, >, <,>=,<=
		public override bool Equals( object obj ) { return !ReferenceEquals( null, obj ) && ( obj is String16 && Equals( ( String16 ) obj ) ); }
		public override int GetHashCode() { unchecked { return ( _2.GetHashCode() * 0x18d ) ^ _1.GetHashCode(); } }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator >( String16 a, String16 b ) { return a._1 > b._1 || a._1 == b._1 && a._2 > b._2; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator <( String16 a, String16 b ) { return a._1 < b._1 || a._1 == b._1 && a._2 < b._2; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator >=( String16 a, String16 b ) { return a._1 > b._1 || a._1 == b._1 && a._2 >= b._2; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator <=( String16 a, String16 b ) { return a._1 < b._1 || a._1 == b._1 && a._2 <= b._2; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator ==( String16 a, String16 b ) { return a._1 == b._1 && a._2 == b._2; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator !=( String16 a, String16 b ) { return a._1 != b._1 || a._2 != b._2; }

		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public bool Equals( String16 other ) {return _2 == other._2 && _1 == other._1;}
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public int CompareTo( object obj ) {
			var b = ( String16 ) obj;
		    var cmp = this._1.CompareTo( b._1 );
			return cmp != 0 ? cmp : this._2.CompareTo( b._2 );
		}
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public int CompareTo( String16 b ) {
		    var cmp = this._1.CompareTo( b._1 );
		    return cmp != 0 ? cmp : this._2.CompareTo( b._2 );
		}

	    [MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static int Compare( String16 a, String16 b ) {
	        var cmp = a._1.CompareTo( b._1 );
	        return cmp != 0 ? cmp : a._2.CompareTo( b._2 );
	    }

	    #endregion
		#region String conversions
		public static String16 FromString( string s ) {
			fixed ( char* rc = s ) {
				String16 ret;
				Helper.FillAsciiBytes( ( byte* ) &ret, rc, s.Length, sizeof( String16 ) );
				return ret;
			}
		}
		public override string ToString() {fixed ( String16* r = &this )return Helper.ToString( ( byte* ) r, sizeof( String16 ) );}
		public static explicit operator String16( string s ) { return FromString( s ); }
		#endregion
	}
	/// <summary>
	/// Compact ascii string storage(24 chars max)
	/// </summary>
	public unsafe struct String24 : IComparable, IComparable<String24>, IEquatable<String24> {

		private ulong _3;
		private ulong _2;
		private ulong _1;

		#region Comparators : IComparable, IComparable<String24>, IEquatable<String24>, ==, !=, >, <,>=,<=
		public override bool Equals( object obj ){return !ReferenceEquals(null, obj) && (obj is String24 && Equals((String24) obj));}
		public override int GetHashCode() { unchecked { return ( ( ( _3.GetHashCode() * 397 ) ^ _2.GetHashCode() ) * 397 ) ^ _1.GetHashCode(); } }

		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator >( String24 a, String24 b ) { return a._1 > b._1 || a._1 == b._1 && ( a._2 > b._2 || a._2 == b._2 && a._3 > b._3 ); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator <( String24 a, String24 b ) { return a._1 < b._1 || a._1 == b._1 && ( a._2 < b._2 || a._2 == b._2 && a._3 < b._3 ); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator >=( String24 a, String24 b ) { return a._1 > b._1 || a._1 == b._1 && ( a._2 > b._2 || a._2 == b._2 && a._3 >= b._3 ); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator <=( String24 a, String24 b ) { return a._1 < b._1 || a._1 == b._1 && ( a._2 < b._2 || a._2 == b._2 && a._3 <= b._3 ); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator ==( String24 a, String24 b ) { return a._1 == b._1 && a._2 == b._2 && a._3 == b._3; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator !=( String24 a, String24 b ) { return a._1 != b._1 || a._2 != b._2 || a._3 != b._3; }

		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public bool Equals( String24 other ) {return _3 == other._3 && _2 == other._2 && _1 == other._1;}
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public int CompareTo( object obj ) {
			var b = ( String24 ) obj;
		    var cmp = this._1.CompareTo( b._1 );
			if ( cmp != 0 ) return cmp;
			cmp = this._2.CompareTo( b._2 );
			return cmp != 0 ? cmp : this._3.CompareTo( b._3 );
		}
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public int CompareTo( String24 b ) {
		    var cmp = this._1.CompareTo( b._1 );
			if ( cmp != 0 ) return cmp;
			cmp = this._2.CompareTo( b._2 );
			return cmp != 0 ? cmp : this._3.CompareTo( b._3 );
		}
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static int Compare( String24 a, String24 b ) {
		    var cmp = a._1.CompareTo( b._1 );
			if ( cmp != 0 ) return cmp;
			cmp = a._2.CompareTo( b._2 );
			return cmp != 0 ? cmp : a._3.CompareTo( b._3 );
		}
		#endregion
		#region String conversions
		public static String24 FromString( string s ) {
			fixed ( char* rc = s ) {
				String24 ret;
				Helper.FillAsciiBytes( ( byte* ) &ret, rc, s.Length, sizeof( String24 ) );
				return ret;
			}
		}
		public static explicit operator String24( string s ) { return FromString( s ); }
		public override string ToString() {fixed ( String24* r = &this )return Helper.ToString( ( byte* ) r, sizeof( String24 ) );}
		#endregion
	}
	/// <summary>
	/// Compact ascii string storage(32 chars max)
	/// </summary>
	public unsafe struct String32 : IComparable, IComparable<String32>, IEquatable<String32> {

		private ulong _4;
		private ulong _3;
		private ulong _2;
		private ulong _1;

		#region Comparators : IComparable, IComparable<String24>, IEquatable<String24>, ==, !=, >, <,>=,<=
		public override bool Equals( object obj ) { return !ReferenceEquals( null, obj ) && ( obj is String32 && Equals( ( String32 ) obj ) ); }
		public override int GetHashCode() { unchecked { return _4.GetHashCode() * 397 ^ _3.GetHashCode() * 397 ^ _2.GetHashCode() * 397 ^ _1.GetHashCode(); } }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator >( String32 a, String32 b ) { return a._1 > b._1 || a._1 == b._1 && ( a._2 > b._2 || a._2 == b._2 && ( a._3 > b._3 || a._3 == b._3 && a._4 > b._4 ) ); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator <( String32 a, String32 b ) { return a._1 < b._1 || a._1 == b._1 && ( a._2 < b._2 || a._2 == b._2 && ( a._3 < b._3 || a._3 == b._3 && a._4 < b._4 ) ); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator >=( String32 a, String32 b ) { return a._1 > b._1 || a._1 == b._1 && ( a._2 > b._2 || a._2 == b._2 && ( a._3 > b._3 || a._3 == b._3 && a._4 >= b._4 ) ); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator <=( String32 a, String32 b ) { return a._1 < b._1 || a._1 == b._1 && ( a._2 < b._2 || a._2 == b._2 && ( a._3 < b._3 || a._3 == b._3 && a._4 <= b._4 ) ); }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator ==( String32 a, String32 b ) { return a._1 == b._1 && a._2 == b._2 && a._3 == b._3 && a._4 == b._4; }
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static bool operator !=( String32 a, String32 b ) { return a._1 != b._1 || a._2 != b._2 || a._3 != b._3 || a._4 != b._4; }

		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public bool Equals( String32 other ) {return _4 == other._4 && _3 == other._3 && _2 == other._2 && _1 == other._1;}
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public int CompareTo( object obj ) {
			var b = ( String32 ) obj;
		    var cmp = this._1.CompareTo( b._1 );
			if ( cmp != 0 ) return cmp;
			cmp = this._2.CompareTo( b._2 );
			if ( cmp != 0 ) return cmp;
			cmp = this._3.CompareTo( b._3 );
			return cmp != 0 ? cmp : this._4.CompareTo( b._4 );
		}
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public int CompareTo( String32 b ) {
		    var cmp = this._1.CompareTo( b._1 );
			if ( cmp != 0 ) return cmp;
			cmp = this._2.CompareTo( b._2 );
			if ( cmp != 0 ) return cmp;
			cmp = this._3.CompareTo( b._3 );
			return cmp != 0 ? cmp : this._4.CompareTo( b._4 );
		}
		[MethodImplAttribute( MethodImplOptions.AggressiveInlining )]
		public static int Compare( String32 a, String32 b ) {
		    var cmp = a._1.CompareTo( b._1 );
			if ( cmp != 0 ) return cmp;
			cmp = a._2.CompareTo( b._2 );
			if ( cmp != 0 ) return cmp;
			cmp = a._3.CompareTo( b._3 );
			return cmp != 0 ? cmp : a._4.CompareTo( b._4 );
		}
		#endregion
		#region String conversions
		public static String32 FromString( string s ) {
			fixed ( char* rc = s ) {
				String32 ret;
				Helper.FillAsciiBytes( ( byte* ) &ret, rc, s.Length, sizeof( String32 ) );
				return ret;
			}
		}
		public static explicit operator String32( string s ) { return FromString( s ); }
		public override string ToString() {fixed (String32* r = &this) return Helper.ToString((byte*) r, sizeof (String32));}
		#endregion
	}
	internal static class Helper {
		internal static unsafe void FillAsciiBytes( byte* to, char* from, int count, int size ) {
			var read = ( ( byte* ) from );//read from
			var end = to + size - 1;						//struct end
			var write = end - Math.Min( size, count ) - 1;	//write end
			while ( end > write ) {
				*end = *read;
				--end; read += sizeof( char );
			}
		    while ( end > to ) {
				*end-- = 0;
			}
		}
		internal static unsafe string ToString( byte* read, int count ) {
			var cnt = 0;
			var end = read + count - 1;
			byte tmp;
			var output = new char[ count ];
			while ( end > read && ( tmp = *( end-- ) ) != 0 )
				output[ cnt++ ] = ( char ) tmp;
			return new String( output, 0, cnt );
		}
	}
}
