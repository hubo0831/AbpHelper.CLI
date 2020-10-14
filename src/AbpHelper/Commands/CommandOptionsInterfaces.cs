using EasyAbp.AbpHelper.Attributes;

namespace EasyAbp.AbpHelper.Commands.Generate
{
    public interface ITemplateTypeHost
    {
        string TemplateType { get; }
    }

    public interface IModuleDirHost
    {
        string ModuleDir { get; }
    }
}