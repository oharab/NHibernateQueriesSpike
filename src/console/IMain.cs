/*
 * User: 721116
 * Date: 28/08/2012
 * Time: 13:32
 * 
 *  */
using System;

namespace console
{
	/// <summary>
	/// Description of IMain.
	/// </summary>
	public interface IMain
	{
		void Begin();
		void AddSomeBlogs();
		
		void GetBlogByTitle(string blogTitle);
		
		void AddSomeCommentsTo(string blogTitle);
		
		void CountAllComments();
	}
}
