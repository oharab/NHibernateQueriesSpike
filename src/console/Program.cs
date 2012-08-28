/*
 * User: 721116
 * Date: 28/08/2012
 * Time: 12:43
 * 
 *  */
using System;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace console
{
	class Program
	{
		private static IWindsorContainer container;
		
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Starting Main");
			
			container=new WindsorContainer();
			
			container.Install(
				 FromAssembly.This()
			);
			
			IMain app=container.Resolve<IMain>();
			app.Begin();
			app.AddSomeBlogs();
			
			Console.Write("Completed.");
			
			container.Dispose();
			Console.ReadKey(true);
		}
		
	}
}