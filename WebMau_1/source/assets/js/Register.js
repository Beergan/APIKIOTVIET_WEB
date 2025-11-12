const container = document.getElementById('authenContainer');

document.addEventListener('click', (e) => {
    const target = e.target;

    if (target.id === 'signUp') {
        container.classList.add('right-panel-active');
    }

    if (target.id === 'signIn') {
        container.classList.remove('right-panel-active');
    }
});
