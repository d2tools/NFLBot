﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BungieNet.Api
{
	public interface IContentClient
	{
		Content.Models.ContentTypeDescription GetContentType(string type);
		Task<Content.Models.ContentTypeDescription> GetContentTypeAsync(string type);

		Content.ContentItemPublicContract GetContentById(long id, string locale, bool head);
		Task<Content.ContentItemPublicContract> GetContentByIdAsync(long id, string locale, bool head);

		Content.ContentItemPublicContract GetContentByTagAndType(string tag, string type, string locale, bool head);
		Task<Content.ContentItemPublicContract> GetContentByTagAndTypeAsync(string tag, string type, string locale, bool head);

		SearchResultOfContentItemPublicContract SearchContentWithText(string locale, string ctype, int currentpage, bool head, string searchtext, string source, string tag);
		Task<SearchResultOfContentItemPublicContract> SearchContentWithTextAsync(string locale, string ctype, int currentpage, bool head, string searchtext, string source, string tag);

		SearchResultOfContentItemPublicContract SearchContentByTagAndType(string tag, string type, string locale, int currentpage, bool head, int itemsperpage);
		Task<SearchResultOfContentItemPublicContract> SearchContentByTagAndTypeAsync(string tag, string type, string locale, int currentpage, bool head, int itemsperpage);

		Content.ContentItemPublicContract[] SearchHelpArticles(string searchtext, string size);
		Task<Content.ContentItemPublicContract[]> SearchHelpArticlesAsync(string searchtext, string size);
	}

	partial interface IBungieClient
	{
		IContentClient Content { get; }
	}

	partial class BungieClient : IContentClient
	{
		public IContentClient Content => this;


		Content.Models.ContentTypeDescription IContentClient.GetContentType(string type) => Content.GetContentTypeAsync(type).GetAwaiter().GetResult();
		Task<Content.Models.ContentTypeDescription> IContentClient.GetContentTypeAsync(string type)
		{
			if (type is null)
				throw new ArgumentNullException(nameof(type));
			string[] pathSegments = new string[] { "Content", "GetContentType", type };
			Uri uri = GetEndpointUri(pathSegments, true, null);
			return GetEntityAsync<Content.Models.ContentTypeDescription>(uri);
		}

		Content.ContentItemPublicContract IContentClient.GetContentById(long id, string locale, bool head) => Content.GetContentByIdAsync(id, locale, head).GetAwaiter().GetResult();
		Task<Content.ContentItemPublicContract> IContentClient.GetContentByIdAsync(long id, string locale, bool head)
		{
			if (locale is null)
				throw new ArgumentNullException(nameof(locale));
			string[] pathSegments = new string[] { "Content", "GetContentById", id.ToString(), locale };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("head", head.ToString().ToLower())
			};
			Uri uri = GetEndpointUri(pathSegments, true, queryItems);
			return GetEntityAsync<Content.ContentItemPublicContract>(uri);
		}

		Content.ContentItemPublicContract IContentClient.GetContentByTagAndType(string tag, string type, string locale, bool head) => Content.GetContentByTagAndTypeAsync(tag, type, locale, head).GetAwaiter().GetResult();
		Task<Content.ContentItemPublicContract> IContentClient.GetContentByTagAndTypeAsync(string tag, string type, string locale, bool head)
		{
			if (tag is null)
				throw new ArgumentNullException(nameof(tag));
			if (type is null)
				throw new ArgumentNullException(nameof(type));
			if (locale is null)
				throw new ArgumentNullException(nameof(locale));
			string[] pathSegments = new string[] { "Content", "GetContentByTagAndType", tag, type, locale };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("head", head.ToString().ToLower())
			};
			Uri uri = GetEndpointUri(pathSegments, true, queryItems);
			return GetEntityAsync<Content.ContentItemPublicContract>(uri);
		}

		SearchResultOfContentItemPublicContract IContentClient.SearchContentWithText(string locale, string ctype, int currentpage, bool head, string searchtext, string source, string tag) => Content.SearchContentWithTextAsync(locale, ctype, currentpage, head, searchtext, source, tag).GetAwaiter().GetResult();
		Task<SearchResultOfContentItemPublicContract> IContentClient.SearchContentWithTextAsync(string locale, string ctype, int currentpage, bool head, string searchtext, string source, string tag)
		{
			if (locale is null)
				throw new ArgumentNullException(nameof(locale));
			string[] pathSegments = new string[] { "Content", "Search", locale };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("ctype", (ctype ?? "")),
				new QueryStringItem("currentpage", currentpage.ToString()),
				new QueryStringItem("head", head.ToString().ToLower()),
				new QueryStringItem("searchtext", (searchtext ?? "")),
				new QueryStringItem("source", (source ?? "")),
				new QueryStringItem("tag", (tag ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, true, queryItems);
			return GetEntityAsync<SearchResultOfContentItemPublicContract>(uri);
		}

		SearchResultOfContentItemPublicContract IContentClient.SearchContentByTagAndType(string tag, string type, string locale, int currentpage, bool head, int itemsperpage) => Content.SearchContentByTagAndTypeAsync(tag, type, locale, currentpage, head, itemsperpage).GetAwaiter().GetResult();
		Task<SearchResultOfContentItemPublicContract> IContentClient.SearchContentByTagAndTypeAsync(string tag, string type, string locale, int currentpage, bool head, int itemsperpage)
		{
			if (tag is null)
				throw new ArgumentNullException(nameof(tag));
			if (type is null)
				throw new ArgumentNullException(nameof(type));
			if (locale is null)
				throw new ArgumentNullException(nameof(locale));
			string[] pathSegments = new string[] { "Content", "SearchContentByTagAndType", tag, type, locale };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("currentpage", currentpage.ToString()),
				new QueryStringItem("head", head.ToString().ToLower()),
				new QueryStringItem("itemsperpage", itemsperpage.ToString())
			};
			Uri uri = GetEndpointUri(pathSegments, true, queryItems);
			return GetEntityAsync<SearchResultOfContentItemPublicContract>(uri);
		}

		Content.ContentItemPublicContract[] IContentClient.SearchHelpArticles(string searchtext, string size) => Content.SearchHelpArticlesAsync(searchtext, size).GetAwaiter().GetResult();
		Task<Content.ContentItemPublicContract[]> IContentClient.SearchHelpArticlesAsync(string searchtext, string size)
		{
			if (searchtext is null)
				throw new ArgumentNullException(nameof(searchtext));
			if (size is null)
				throw new ArgumentNullException(nameof(size));
			string[] pathSegments = new string[] { "Content", "SearchHelpArticles", searchtext, size };
			Uri uri = GetEndpointUri(pathSegments, false, null);
			return GetEntityArrayAsync<Content.ContentItemPublicContract>(uri);
		}
	}
}