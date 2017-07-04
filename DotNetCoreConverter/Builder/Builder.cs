namespace DotNetCoreConverter.Builder
{
    public interface Builder<T>
    {
         void Build(T value);
         void Save(string path);
    }
}