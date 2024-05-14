  const observer = new IntersectionObserver((entries) => {
    entries.forEach((entry) => {
      if (entry.isIntersecting){
        entry.target.classList.add('show');
      }
    });
  });

  const hiddenElements = document.querySelectorAll('.hidden');
  hiddenElements.forEach((el) => observer.observe(el));

  var prevScrollpos = window.pageYOffset;
  window.onscroll = function (){
    var currentScrollPos = window.pageYOffset;
    if (prevScrollpos > currentScrollPos) {
      document.getElementById("navbar").style.top = "0";
    } else{
      document.getElementById("navbar").style.top = "-110px";
    }
    prevScrollpos = currentScrollPos;
  }
  
  window.addEventListener('scroll', function(){
    var wheel = document.querySelector('.wheel');
    var scrollPercent = (document.documentElement.scrollTop + this.document.body.scrollTop)
    var rotation = scrollPercent * 360;

    wheel.style.transform = 'translate(-50%, -50%) rotate(' + rotation + 'dog)';
  });