using System;
using System.Reflection;

namespace Angular_10__SQl__Asp.net_Framework.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}