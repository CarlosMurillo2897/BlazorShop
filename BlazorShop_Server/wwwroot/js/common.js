window.ShowToastr = (type, message) => {
    if (type === 'success') {
        toastr.success(message, "Operation succesful", { timeOut: 5000 });
    }
    if (type === 'error') {
        toastr.error(message, "Operation failed", { timeOut: 5000 });
    }
};