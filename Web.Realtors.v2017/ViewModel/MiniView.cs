using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Realtors.ViewModel
{
	public class MiniView
	{
		public string Title
		{
			get; set;
		}

		public string Description
		{
			get; set;
		}

		public float Price
		{
			get; set;
		}

		public string Rent	
		{
			get; set;
		}

		public string MainImageSrc
		{
			get; set;
		}

		public List<string> ImagesSrc
		{
			get; set;
		}

		public string MainViewHref
		{
			get; set;
		}

		public string LastEdited
		{
			get; set;
		}

		public string PropertyType
		{
			get; set;
		}

		public int Ratings
		{
			get; set;
		}

		public int TotalViews
		{
			get; set;
		}
	}
}

