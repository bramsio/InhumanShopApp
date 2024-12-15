
function goBack() {
    const referrer = document.referrer;

    if (referrer) {
        window.location.href = referrer;
    } else if (window.history.length > 1) {
        window.history.back();
    } else {
        window.location.href = '/';
    }
}