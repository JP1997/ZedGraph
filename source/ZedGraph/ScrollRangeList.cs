//============================================================================
//ZedGraph Class Library - A Flexible Line Graph/Bar Graph Library in C#
//Copyright (C) 2005  John Champion
//
//This library is free software; you can redistribute it and/or
//modify it under the terms of the GNU Lesser General Public
//License as published by the Free Software Foundation; either
//version 2.1 of the License, or (at your option) any later version.
//
//This library is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//Lesser General Public License for more details.
//
//You should have received a copy of the GNU Lesser General Public
//License along with this library; if not, write to the Free Software
//Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//=============================================================================

#region Using directives

using System;
using System.Collections;
using System.Text;
using System.Runtime.Serialization;
using System.Security.Permissions;

#endregion

namespace ZedGraph
{
	/// <summary>
	/// A collection class containing a list of <see cref="ScrollRange"/> objects.
	/// </summary>
	/// 
	/// <author>John Champion</author>
	/// <version> $Revision: 3.1 $ $Date: 2005-09-24 09:13:32 $ </version>
	public class ScrollRangeList : CollectionPlus
	{

	#region Constructors

		/// <summary>
		/// Default constructor for the collection class.
		/// </summary>
		public ScrollRangeList()
		{
		}

		/// <summary>
		/// The Copy Constructor
		/// </summary>
		/// <param name="rhs">The <see cref="ScrollRangeList"/> object from which to copy</param>
		public ScrollRangeList( ScrollRangeList rhs )
		{
			foreach ( ScrollRange item in rhs )
				this.Add( new ScrollRange( item ) );
		}
				
		/// <summary>
		/// Deep-copy clone routine
		/// </summary>
		/// <returns>A new, independent copy of the <see cref="ScrollRangeList"/>.</returns>
		public object Clone()
		{ 
			return new ScrollRangeList( this ); 
		}
		
	#endregion

	#region List Methods

		/// <summary>
		/// Indexer to access the specified <see cref="ScrollRange"/> object by
		/// its ordinal position in the list.
		/// </summary>
		/// <param name="index">The ordinal position (zero-based) of the
		/// <see cref="ScrollRange"/> object to be accessed.</param>
		/// <value>A <see cref="ScrollRange"/> object instance</value>
		public ScrollRange this[ int index ]  
		{
			get
			{
				if ( index < 0 || index >= this.Count )
					return new ScrollRange( false );
				else
					return (ScrollRange) List[index];
			}
			set { List[index] = value; }
		}

		/// <summary>
		/// Add a <see cref="ScrollRange"/> object to the collection at the end of the list.
		/// </summary>
		/// <param name="item">The <see cref="ScrollRange"/> object to be added</param>
		/// <seealso cref="IList.Add"/>
		public int Add( ScrollRange item )
		{
			return List.Add( item );
		}

		/// <summary>
		/// Insert a <see cref="ScrollRange"/> object into the collection at the specified
		/// zero-based index location.
		/// </summary>
		/// <param name="index">The zero-based index location for insertion.</param>
		/// <param name="item">The <see cref="ScrollRange"/> object that is to be
		/// inserted.</param>
		/// <seealso cref="IList.Insert"/>
		public void Insert( int index, ScrollRange item )
		{
			List.Insert( index, item );
		}

	#endregion

	}
}
