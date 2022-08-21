window.ShowToastr = (type, message) => {
    if (type === 'success') {
        toastr.success(message, "Operation succesful", { timeOut: 5000 });
    }
    if (type === 'error') {
        toastr.error(message, "Operation failed", { timeOut: 5000 });
    }
};

window.ShowSwal = (type, message) => {
    if (type === 'success') {
        Swal.fire("Succes Notification!", message, 'success');
    }
    if (type === 'error') {
        Swal.fire("Error Notification!", message, 'error');
    }
};