/*
 * User: 721116
 * Date: 28/08/2012
 * Time: 14:30
 * 
 *  */
using System;
using System.Collections.Generic;

namespace console.Domain
{
	/// <summary>
	/// Description of Blog.
	/// </summary>
	public class Blog
	{
		public Blog(){
			Comments=new List<Comment>();
		}
		public virtual Guid Id { get; set; }
		public virtual string Title { get; set; }
		public virtual string Text { get; set; }
		
		public virtual DateTime CreatedDate { get; set; }
		
		public virtual IList<Comment> Comments { get; set; }
		
	}
}
