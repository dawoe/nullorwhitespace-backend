//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace NullOrWhitespace.Models
{
	/// <summary>Page</summary>
	[PublishedContentModel("page")]
	public partial class Page : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "page";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Page(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Page, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Description: Appears in Google search results. It should be descriptive and in complete sentences. Include value statements and a call-to-action (click here, learn more by clicking here, download here, view video, etc) so people click the link. Include relevant keywords. 50-155 characters.
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return this.GetPropertyValue<string>("metaDescription"); }
		}

		///<summary>
		/// Meta Keywords: Used by smaller search engines but not Google, Bing or Yahoo. The meta keywords to display to search engines. List in order of relevance and importance. Separate words or phrases with a comma. Include misspellings and variations. Include action words such as buy, shop, find, download or words related to your industry.
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return this.GetPropertyValue<string>("metaKeywords"); }
		}

		///<summary>
		/// Page Title: Overrides the default page title.
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return this.GetPropertyValue<string>("pageTitle"); }
		}
	}
}
