/*
 * User: 721116
 * Date: 28/08/2012
 * Time: 14:32
 * 
 *  */
using System;

namespace console.Domain
{
	/// <summary>
	/// Description of Comment.
	/// </summary>
	public class Comment
	{
		public virtual Guid Id { get; set; }
		public virtual string Author { get; set; }
		public virtual string Text { get; set; }
	}
}
