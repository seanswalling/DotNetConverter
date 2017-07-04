namespace DotNetCoreConverter.Loaders
{
    public interface Loader<T>
    {
         T Load();
    }
}