using Microsoft.JSInterop;

namespace BlazorShop_Server.Helpers {
    public static class IJSRuntimeExtension {
        public static async ValueTask ToastrSuccess(this IJSRuntime JSRuntime, string message) {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async ValueTask ToastrFailure(this IJSRuntime JSRuntime, string message) {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
    }
}
