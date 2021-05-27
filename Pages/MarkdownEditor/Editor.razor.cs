using System;
using Markdig;
using Microsoft.AspNetCore.Components;

namespace BlazorExamples.Pages.MarkdownEditor
{
    public class MarkdownEditorBase : ComponentBase
    {
        public string Body { get; set; } = string.Empty;
        public string Preview => Markdown.ToHtml(Body);
    }
}