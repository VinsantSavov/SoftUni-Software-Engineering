function notify(message) {
  const div = document.getElementById('notification');

  div.style.display = 'block';
  div.textContent = message;

  div.addEventListener('click', e => e.target.style.display = 'none');
}