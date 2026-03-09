using System.Reflection;
using System.Threading.Tasks;

namespace EclipseProject
{
    public static class Loader
    {
        public static async Task Main()
        {
            
            await EclipseClient.Initialize();
        }
    }
}