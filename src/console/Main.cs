﻿/*
 * User: 721116
 * Date: 28/08/2012
 * Time: 13:33
 * 
 *  */
using System;
using Castle.Core.Logging;
using console.Domain;
using NHibernate;

namespace console
{
	/// <summary>
	/// Description of Main.
	/// </summary>
	public class Main:IMain
	{
		ILogger logger;
		ISession session;
		public Main(ILogger logger,ISession session)
		{
			this.logger=logger;
			this.session=session;
		}
		
		public void Begin(){
			logger.Debug("Beginning");
		}
		
		public void AddSomeBlogs()
		{
			logger.Debug("Adding some blogs");
			
			using(var tx=session.BeginTransaction()){
				session.Save(
					new Blog{
						Title="Blog 1",
						Text=@"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer ut magna vitae ipsum auctor facilisis sit amet ut neque. Donec tristique semper aliquet. Sed at felis lacus. Duis urna ligula, blandit quis imperdiet et, egestas id est. Integer faucibus, leo eu accumsan faucibus, risus erat facilisis sem, vitae dapibus tortor leo molestie quam. Sed sed lobortis velit. Ut ornare euismod blandit. ",
						CreatedDate=DateTime.Today.AddDays(-5)
					}
				);
				
				session.Save(
					new Blog{
						Title="Blog 2",
						Text=@"Nam scelerisque fringilla quam et adipiscing. Proin mollis fringilla augue, sed scelerisque nibh dictum non. Integer laoreet, urna imperdiet tristique rutrum, mauris leo fermentum diam, eget tristique dui felis sit amet mauris. Integer accumsan nisl eu elit porta et egestas lorem dignissim. Sed ac leo ante, commodo bibendum sem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam facilisis dui eget eros fermentum hendrerit. Nam sed eros lorem. Duis ut urna in mi laoreet vestibulum.",
						CreatedDate=DateTime.Today.AddDays(-4)
					}
				);

				session.Save(
					new Blog{
						Title="Blog 3",
						Text=@"Nam ac enim sit amet nulla scelerisque cursus. Nulla eros diam, egestas venenatis ultricies at, iaculis eget neque. Aenean id faucibus dui. Fusce ac massa sed neque varius vulputate. Donec luctus mauris non massa blandit dignissim. Donec eu dignissim dui. Nullam non libero dolor. Aliquam mauris odio, aliquam eu faucibus eu, accumsan at felis. Ut tellus ipsum, convallis et sagittis non, pharetra vel ligula. ",
						CreatedDate=DateTime.Today.AddDays(-3)
					}
				);				

				session.Save(
					new Blog{
						Title="Blog 4",
						Text=@"Aliquam nec ante lectus. Maecenas in nisl sit amet magna mattis scelerisque a id nibh. Aenean a consectetur risus. Nullam imperdiet tellus sit amet enim hendrerit a tincidunt dui dignissim. Pellentesque ac magna at urna porttitor lacinia ut non ante. Praesent vel nibh dui, vitae imperdiet lacus. Proin malesuada ligula mattis sem iaculis pulvinar. Nulla id dui sed risus vehicula ultricies eu eu turpis. Suspendisse facilisis, nibh dictum rutrum convallis, risus urna euismod augue, quis pellentesque nulla nunc id ante. Nullam adipiscing consectetur tortor eu gravida. Donec congue sem ac purus convallis mollis. Sed eu ante non sem pharetra ultrices vitae et ante. Sed tempor dui in ipsum hendrerit rutrum nec id arcu. Donec ipsum tortor, malesuada ut dictum sollicitudin, hendrerit eget ante.",
						CreatedDate=DateTime.Today.AddDays(-2)
					}
				);

				session.Save(
					new Blog{
						Title="Blog 5",
						Text=@"nteger at sapien vel tellus scelerisque elementum. Nulla et justo id odio dapibus tincidunt. Etiam justo nisi, ornare quis lacinia sed, feugiat eu purus. Aliquam ullamcorper arcu sed massa volutpat a pulvinar tortor luctus. Nunc lacus ipsum, scelerisque eu sollicitudin nec, rutrum a nisl. Vestibulum lacus dui, feugiat id vehicula vel, volutpat non tortor. Maecenas luctus augue eu lacus ultrices iaculis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vivamus lacinia blandit luctus. Phasellus convallis aliquet ipsum, ut pharetra nunc molestie non. Nulla pulvinar semper tortor, a tristique odio gravida eu. Phasellus egestas accumsan tempor.",
						CreatedDate=DateTime.Today.AddDays(-1)
					}
				);				
				tx.Commit();
			}
		}
	}
}
