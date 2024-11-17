// ------------------------------------------
// Navegação entre páginas
// ------------------------------------------
function navigateToVisitantes() {
    window.location.href = '/Visitantes/Cadastrar';
}

function redirectToSurvey() {
    window.location.href = '/Questionario/ExibirPerguntas';
}

function redirectToHome() {
    window.location.href = '/Home/Index';
}

// ------------------------------------------
// Scroll
// ------------------------------------------
// Permitir rolagem em uma tela específica
function enableScroll() {
    document.body.classList.add('scrollable');
}

// Desativar rolagem para telas padrão
function disableScroll() {
    document.body.classList.remove('scrollable');
}

// Exemplo de navegação
function navigateTo(screen) {
    if (screen === 'relatorio') {
        enableScroll(); // Ativa rolagem
    } else {
        disableScroll(); // Desativa rolagem
    }
}

// ------------------------------------------
// Modal "Obrigado"
// ------------------------------------------
function showThankYouModal() {
    document.getElementById('thankYouModal').style.display = 'block';
}

// Fechar modal ao clicar fora dele
window.onclick = function (event) {
    const modal = document.getElementById('thankYouModal');
    if (event.target == modal) {
        redirectToHome();
    }
};

// ------------------------------------------
// Slideshow de imagens
// ------------------------------------------
let slideIndex = 0;

function showSlides() {
    const slides = document.querySelectorAll(".slides");

    // Oculta todas as imagens
    slides.forEach(slide => slide.style.display = "none");

    // Avança para a próxima imagem
    slideIndex++;
    if (slideIndex > slides.length) { slideIndex = 1; }

    // Mostra a imagem atual
    slides[slideIndex - 1].style.display = "block";
    slides[slideIndex - 1].classList.add("fade");

    // Mostra a próxima imagem após 8 segundos
    setTimeout(showSlides, 8000);
}

document.addEventListener("DOMContentLoaded", () => {
    showSlides();
});

// ------------------------------------------
// Botões de Sim/Não
// ------------------------------------------
document.querySelectorAll('.sim-nao-button').forEach(button => {
    button.addEventListener('click', function () {
        const parent = this.closest('.sim-nao-options');
        parent.querySelectorAll('.sim-nao-button').forEach(btn => {
            btn.classList.remove('selected');
        });
        this.classList.add('selected');
    });
});

// ------------------------------------------
// Avaliação com estrelas
// ------------------------------------------
document.querySelectorAll('.star-rating').forEach(container => {
    const stars = container.querySelectorAll('.star');
    const index = container.dataset.index;
    const hiddenInput = container.parentElement.querySelector('input[type="hidden"]');

    stars.forEach((star, i) => {
        star.addEventListener('click', () => {
            stars.forEach((s, j) => {
                s.classList.toggle('filled', j <= i);
            });
            hiddenInput.value = i + 1;
        });

        star.addEventListener('mouseover', () => {
            stars.forEach((s, j) => {
                s.classList.toggle('filled', j <= i);
            });
        });
    });

    container.addEventListener('mouseleave', () => {
        const value = hiddenInput.value;
        stars.forEach((s, j) => {
            s.classList.toggle('filled', j < value);
        });
    });
});

// ------------------------------------------
// Seleção de obras
// ------------------------------------------
document.querySelectorAll('.obra-option').forEach(option => {
    option.addEventListener('click', function () {
        const parent = this.closest('.obra-options');
        parent.querySelectorAll('.obra-option').forEach(opt => {
            opt.classList.remove('selected');
        });
        this.classList.add('selected');
    });
});

// ------------------------------------------
// Validação do formulário
// ------------------------------------------
document.querySelector('.questionnaire-form').addEventListener('submit', function (event) {
    let isValid = true;

    // Iterar sobre todas as perguntas
    document.querySelectorAll('.question-container').forEach(function (container) {
        // Verificar se há um input selecionado ou preenchido
        const inputs = container.querySelectorAll('input[type="radio"]:checked, input[type="hidden"]');
        if (inputs.length === 0 || inputs[0].value.trim() === '') {
            isValid = false;

            // Adiciona classe de erro ao container
            container.classList.add('error');
        } else {
            container.classList.remove('error');
        }
    });

    if (!isValid) {
        event.preventDefault(); // Impede o envio do formulário
        alert('Por favor, responda todas as perguntas antes de enviar.');
    }
});

// Remove erro ao clicar em opções de resposta
document.querySelectorAll('input[type="radio"], .star').forEach(function (input) {
    input.addEventListener('change', function () {
        this.closest('.question-container').classList.remove('error');
    });
});

