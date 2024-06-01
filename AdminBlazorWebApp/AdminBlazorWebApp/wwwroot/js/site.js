function toggleMobileMenu() {
    var menu = document.getElementById('mobile-menu');
    if (menu.classList.contains('show')) {
        menu.classList.remove('show');
    } else {
        menu.classList.add('show');
    }
}

function closeMobileMenuOnResize() {
    var menu = document.getElementById('mobile-menu');
    if (menu.classList.contains('show')) {
        menu.classList.remove('show');
    }
}
//Loader
document.addEventListener('DOMContentLoaded', function () {
    var spinner = document.getElementById('loading-spinner');

    function showSpinner() {
        spinner.style.display = 'block';
    }

    function hideSpinner() {
        spinner.style.display = 'none';
    }

    showSpinner();

    hideSpinner();

    window.addEventListener('beforeunload', showSpinner);

    window.addEventListener('blazor:navigation-start', showSpinner);
    window.addEventListener('blazor:navigation-end', hideSpinner);

    document.querySelectorAll('a.nav-link, a.btn-theme').forEach(function (element) {
        element.addEventListener('click', showSpinner);
    });

    hideSpinner();
});
