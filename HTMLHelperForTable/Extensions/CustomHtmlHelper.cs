using Microsoft.AspNetCore.Html;

namespace Microsoft.AspNetCore.Mvc.Rendering
{
	public static class MyHtmlHelperExtensions
	{
		public static IHtmlContent Table(this IHtmlHelper htmlHelper, string[] columnNames, string[,] content)
		{
			var tableBuilder = new TagBuilder("table");
			tableBuilder.Attributes.Add("border", "1");
			var headerBuilder = new TagBuilder("tr");
			foreach (var cn in columnNames)
			{
				var headerCellBuilder = new TagBuilder("th");
				headerCellBuilder.InnerHtml.Append(cn);
				headerBuilder.InnerHtml.AppendHtml(headerCellBuilder);
			}

			tableBuilder.InnerHtml.AppendHtml(headerBuilder);
			int colCount = columnNames.Length;
			int rowCount = content.Length / colCount;
			for (int r = 0; r < rowCount; r++)
			{
				var rowBuilder = new TagBuilder("tr");
				for (int c = 0; c < colCount; c++)
				{
					var cellBuilder = new TagBuilder("td");
					cellBuilder.InnerHtml.Append(content[r, c]);
					rowBuilder.InnerHtml.AppendHtml(cellBuilder);
				}
				tableBuilder.InnerHtml.AppendHtml(rowBuilder);
			}

			return tableBuilder;
		}
	}
}
