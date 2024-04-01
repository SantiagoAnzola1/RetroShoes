//MENU SLIDER RESPONSIVE
function openNav() {
  document.getElementById("mySidebar").style.width = "250px";
  document.body.classList.toggle('shadowslide');
  
  document.documentElement.setAttribute('data-shadow', 'shadow');
  localStorage.setItem('theme','shadow'); 
 //  document.getElementById("main").style.marginLeft = "250px";
   }

   function closeNav() {
   document.getElementById("mySidebar").style.width = "0";
   document.getElementById("main").style.marginLeft= "0";
   document.documentElement.setAttribute('data-shadow', 'none');
  localStorage.setItem('theme','none'); 
   } 






// Slider 1 productos

$(document).ready(function() {
    $('#autoWidth').lightSlider({
        autoWidth:true,
        loop:false,
        onSliderLoad: function() {
            $('#autoWidth').removeClass('cS-hidden');
        } 
    });  
  });

//Notificaciones me gusta 
var notifi=0;
var span = document.getElementById("notifiSpan");
var span0 = document.getElementById("notifiSpan0");
function gfg_Run() {
    span.textContent = notifi;
    span0.textContent = notifi;
    
} 

//Notificaciones me gusta 
var notifi2=0;
var span1 = document.getElementById("notifiSpan2");
var span2 = document.getElementById("notifiSpan21");
function gfg_Run1() {
  notifi2+=1;
    span1.textContent = notifi2;
    span2.textContent = notifi2;
} 

//   $('input[type=checkbox]').removeAttr('checked');

function eliminar(){
  const alertPlaceholder = document.getElementById('liveAlertPlaceholder2')

     
      const wrapper = document.createElement('div')
      wrapper.innerHTML = [
        `<div class="alert alert-danger alert-dismissible  d-flex align-items-center  " role="alert">
        <i class="mx-3 bi bi-bag-x-fill"></i>`,
        `   <div class:"mx-3">Se ha Eliminado correctamente el producto a Me Gusta</div>`,
        '  <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>',
        '</div>'
      ].join('')
      
      alertPlaceholder.append(wrapper)
}
function agregar(){
  
  const alertPlaceholder = document.getElementById('liveAlertPlaceholder1')

     
  const wrapper = document.createElement('div')
  wrapper.innerHTML = [
    `<div class="alert alert-success alert-dismissible  d-flex align-items-center  " role="alert">
    <i class="mx-3 bi bi-bag-check-fill"></i>`,
    `   <div class:"mx-3">Se ha agregado correctamente el producto a Me Gusta</div>`,
    '  <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>',
    '</div>'
  ].join('')
  
  alertPlaceholder.append(wrapper)
  
}
function closeAlert1(){
 
 
  $('#liveAlertPlaceholder1').removeClass('d-none');
  
  setTimeout(() => {
    $('.alert').alert('close');
  }, 4000);
}
function closeAlert2(){
 
 
  $('#liveAlertPlaceholder1').removeClass('d-none');
  
  setTimeout(() => {
    $('.alert').alert('close');
  }, 4000);

}
// LIKE BUTTOM
var cont=0;
    function like(x) {

    x.classList.toggle("like-yes");
    if(cont%2==0){
      cont+=1;
      notifi+=1;
      console.log("Me gusta")
      span.textContent = notifi;
      span0.textContent = notifi;
      const toastLiveExample = document.getElementById('liveToast')
      const toast = new bootstrap.Toast(toastLiveExample)
      toast.show()
    //   agregar();
    //   setTimeout(fusnction () { 
    //     $("#liveAlertPlaceholder1").alert('close'); 
    //  }, 4000); 
    // agregar();
    // closeAlert1();
    }else{
      cont-=1;
      notifi-=1;
      console.log("No Me gusta")
      span.textContent = notifi;
      span0.textContent = notifi;
   
      // eliminar();
      // closeAlert2();
      const toastLiveExample = document.getElementById('liveToast1')
      const toast = new bootstrap.Toast(toastLiveExample)
      toast.show()
    }
    }
var cont1=0;
function dislike(x) {

    x.classList.toggle("like-no");
    
    if(cont1==1){
        cont1-=1;
        notifi+=1;
      x.classList.toggle("like-yes");
      console.log("Me gusta")
      span.textContent = notifi;
      span0.textContent = notifi;
      

      const toastLiveExample = document.getElementById('liveToast')
     
        
       const toast = new bootstrap.Toast(toastLiveExample)
      
      toast.show()
        
      
    //   agregar();
    // closeAlert1();
    }else{
        cont1+=1;
        x.classList.remove("like-yes")
      console.log("No me gusta")
      notifi-=1;
      span.textContent = notifi;
      span0.textContent = notifi;
      // eliminar();
      // closeAlert2();
      const toastLiveExample = document.getElementById('liveToast1')
      const toast = new bootstrap.Toast(toastLiveExample)
      toast.show()
    }
    
    
  }
// SLIDER 2 ME GUSTA

$(document).ready(function() {
    $('#autoWidth1').lightSlider({
        autoWidth:true,
        loop:false,
        onSliderLoad: function() {
            $('#autoWidth1').removeClass('cS-hidden1');
        } 
    });  
  });

// var parent = document.getElementById("multiSlider");
// var nodesSameClass = parent.getElementsByClassName("item-a");
// console.log(nodesSameClass.length);
// con una clase específica
// var tags_li2 = new Array();
// function dli2(clase) {
// var tags_li2=document.getElementsByTagName('li');
// var n = 0;
// var i;
// for (i=0; i<tags_li2.length; i++) {
// if (tags_li2[i].className==multiSlider) {
// n++;
// }
// }
// alert('La cantidad de <li class="' + clase + '"> en el documento es ' + n);
// }
var testElements = document.getElementsByClassName('multiSlider');
var testDivs = Array.prototype.filter.call(testElements, function(testElement){

    return testElement.nodeName === 'li';
   
});
console.log('El numero de items del slider #2 (MeGusta) es:  '+$('#slidermulti .item').length);

if($(('#slidermulti .item').length)<4){
    getElementByClassName("ISAction").style.display="none !important";
    getElementByClassName("ISNext").style.display="none !important";
    getElementByClassName("ISPrev ").style.display="none !important";
    getElementByClassName("ISAction").style.opacity="0 !important";
    getElementByClassName("ISNext").style.opacity="0 !important";
    getElementByClassName("ISPrev ").style.opacity="0 !important";
    

}



/// ALERT


  // const alertPlaceholder = document.getElementById('liveAlertPlaceholder')

  // const alert = (message, type) => {
  //   const wrapper = document.createElement('div')
  //   wrapper.innerHTML = [
  //     `<div class="alert alert-${type} alert-dismissible" role="alert">`,
  //     `   <div>${message}</div>`,
  //     '   <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>',
  //     '</div>'
  //   ].join('')
  
  //   alertPlaceholder.append(wrapper)
  // }
  
  // const alertTrigger = document.getElementById('liveAlertBtn')
  // if (alertTrigger) {
  //   alertTrigger.addEventListener('click', () => {
  //     alert('Nice, you triggered this alert message!', 'success')
  //   })
  // }




  // validation code here ...


  function myFunction() {
    const inpObj = document.getElementById("id1");
    if (!inpObj.checkValidity()) {
      document.getElementById("id1").innerHTML = inpObj.validationMessage;
    } else {
  
      const alertPlaceholder = document.getElementById('liveAlertPlaceholder')

      const alert = (message, type) => {
        const wrapper = document.createElement('div')
        wrapper.innerHTML = [
          `<div class="alert alert-${type} alert-dismissible  d-flex align-items-center  " role="alert">
          <i class="mx-3 bi bi-exclamation-circle-fill"></i>`,
          `   <div class:"mx-3">${message}</div>`,
          ' <a href="olvidocontrasena.html"> <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button></a>',
          '</div>'
        ].join('')
      
        alertPlaceholder.append(wrapper)
      }
      
      const alertTrigger = document.getElementById('olvcontr')
      if (alertTrigger) {
       
          alert('Se ha enviado un mensaje a tu correo', 'primary')
      
      }
    } 
  }




  const alertPlaceholder = document.getElementById('liveAlertPlaceholder')

const alert = (message, type) => {
  const wrapper = document.createElement('div')
  wrapper.innerHTML = [
    `<div class="alert alert-${type} alert-dismissible" role="alert">`,
    `   <div>${message}</div>`,
    '   <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>',
    '</div>'
  ].join('')

  alertPlaceholder.append(wrapper)
}

const alertTrigger = document.getElementById('liveAlertBtn')
if (alertTrigger) {
  alertTrigger.addEventListener('click', () => {
    alert('Nice, you triggered this alert message!', 'success')
  })
}


const toastTrigger = document.getElementById('liveToastBtn')
const toastLiveExample = document.getElementById('liveToast')
if (toastTrigger) {
  toastTrigger.addEventListener('click', () => {
    const toast = new bootstrap.Toast(toastLiveExample)

    toast.show()
  })
}

toastTrigger.setMaxCount(6);
toastTrigger.enableQueue(true)