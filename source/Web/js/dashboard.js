window.addEventListener('DOMContentLoaded', event => {
  const sidebarToggle = document.body.querySelector('#sidebarToggle');
  if (sidebarToggle) {
    sidebarToggle.addEventListener('click', event => {
      event.preventDefault();
      document.body.classList.toggle('sidenav-toggled');
      localStorage.setItem('sidebar-toggle', document.body.classList.contains('sidenav-toggled'));
    });
  }
});