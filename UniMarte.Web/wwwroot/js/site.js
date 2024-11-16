// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function navigateToVisitantes() {
    window.location.href = '/Visitantes/Cadastrar';
}

function redirectToSurvey() {
    window.location.href = '/Questionario/ExibirPerguntas';
}

function showThankYouModal() {
    document.getElementById('thankYouModal').style.display = 'block';
}

function redirectToHome() {
    window.location.href = '/Home/Index';
}

// Fechar modal se clicar fora dele
window.onclick = function (event) {
    var modal = document.getElementById('thankYouModal');
    if (event.target == modal) {
        redirectToHome();
    }
}

let slideIndex = 0;

// Função para exibir o slideshow
function showSlides() {
    const slides = document.querySelectorAll(".slides");

    // Oculta todas as imagens
    slides.forEach(slide => slide.style.display = "none");

// Avança para a próxima imagem
slideIndex++;
    if (slideIndex > slides.length) {slideIndex = 1; }

// Mostra a imagem atual
slides[slideIndex - 1].style.display = "block";
slides[slideIndex - 1].classList.add("fade");

// Mostra a próxima imagem após 8 segundos
setTimeout(showSlides, 8000);
}

// Inicializa o slideshow
document.addEventListener("DOMContentLoaded", () => {
    showSlides();
});


