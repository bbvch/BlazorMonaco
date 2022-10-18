using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorMonaco
{
    public class Languages
    {
        
        private readonly IJSRuntime jsRuntime;

        public Languages(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }
        
        public async Task SetJsonDiagnosticsOptionsAsync(DiagnosticOptions options)
        {
            await jsRuntime.InvokeVoidAsync("blazorMonaco.languages.json.jsonDefaults.setDiagnosticsOptions", options);

        }
    }
}