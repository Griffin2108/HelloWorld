document.addEventListener("scroll", function() {
    var sections = document.querySelectorAll('.section');
    sections.forEach(function(section) {
      var rect = section.getBoundingClientRect();
      var fadeInElement = section.querySelector('.fade-in');
      var fadeOutElement = section.querySelector('.fade-out');
  
      if (rect.top >= 0 && rect.bottom <= window.innerHeight) {
        fadeInElement.classList.add('fade-in-active');
        fadeOutElement.classList.add('fade-out-active');
      } else {
        fadeInElement.classList.remove('fade-in-active');
        fadeOutElement.classList.remove('fade-out-active');
      }
    });
  });
  