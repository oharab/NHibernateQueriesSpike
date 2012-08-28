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
			
			Console.WriteLine("Loading container");
			
			container=new WindsorContainer();
			container.Install(
				 FromAssembly.This()
			);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Completed.");
			Console.ReadKey(true);
			
			container.Dispose();
		}
	}
}