using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BuilderPattern
{
	class HttpRequest
	{
		string url;
		string filter;
		string ordering;
		short top;
		short skip;

		public HttpRequest(HttpRequestBuilder builder)
		{
			this.url = builder.url;
			this.filter = builder.filter;
			this.ordering = builder.ordering;
			this.top = builder.top;
			this.skip = builder.skip;
		}

		public class HttpRequestBuilder {
			public string url;
			public string filter;
			public string ordering;
			public short top;
			public short skip;

			public HttpRequestBuilder(string url)
			{
				this.url = url;
			}

			public HttpRequest Build()
			{
				return new HttpRequest(this);
			}

			public HttpRequestBuilder SetFilter(string filter) {
				this.filter = filter;
				return this;
			}

			public HttpRequestBuilder SetOrdering(string ordering)
			{
				this.ordering = ordering;
				return this;
			}

			public HttpRequestBuilder SetTop(short top)
			{
				this.top = top;
				return this;
			}

			public HttpRequestBuilder SetSkip(short skip)
			{
				this.skip = skip;
				return this;
			}
		}
	}
}
