
const API_URL = window.location.hostname === 'localhost'
  ? "http://localhost:3000/destaque" 
  : "/api/destaque";

/*---Cadastro---*/
document.addEventListener('DOMContentLoaded', () => {
    const formCadastro = document.getElementById("formCadastro");
    if (formCadastro){
        formCadastro.addEventListener("submit", async (event) => {
            event.preventDefault();

            const nome = document.getElementById('nome').value;
            const email = document.getElementById('email').value.trim(); 
            const senha = document.getElementById('senha').value;

            let novoUsuario = {nome, email, senha};
            
            try {
                const response = await fetch(API_URL, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(novoUsuario)
                });

                if (!response.ok){
                    throw new Error(`Erro: ${response.statusText}`);  
                }

                alert("Cadastro realizado com sucesso!");
                window.location.href = './login.html';
            } catch (error) {
                console.error("Erro ao cadastrar usuário:", error);
                alert("Erro ao cadastrar usuário.");
            }
        });
    }
});

/* --- Login -- */
document.addEventListener("DOMContentLoaded", () => {
    const formLogin = document.getElementById("formLogin");

    if (formLogin) {
        formLogin.addEventListener("submit", async (e) => {
            e.preventDefault();
            const emailRaw = document.getElementById("email").value.trim();
            const senhaRaw = document.getElementById("senha").value.trim();
            
            if (!emailRaw || !senhaRaw) {
                alert("Preencha todos os campos!");
                return;
            }

            const email = emailRaw.toLowerCase();
            const emailEncoded = encodeURIComponent(email);
            const senhaEncoded = encodeURIComponent(senhaRaw);

            console.log(`Tentando logar com: ${email}`);

            try {
                const urlBusca = `${API_URL}?email=${emailEncoded}&senha=${senhaEncoded}`;
                
                const response = await fetch(urlBusca);
                const usuarios = await response.json();

                if (usuarios.length === 0) {
                    const checkEmail = await fetch(`${API_URL}?email=${emailEncoded}`);
                    const userEmail = await checkEmail.json();
                    
                    if(userEmail.length > 0) {
                        alert("Senha incorreta!");
                    } else {
                        alert("E-mail não encontrado.");
                    }
                    return;
                }

                const usuario = usuarios[0];
                localStorage.setItem("usuarioLogado", JSON.stringify(usuario)); 

                alert("Login realizado com sucesso!");
                window.location.href = '../index.html';

            } catch (error) {
                console.error("Erro no login:", error);
                alert("Erro de sistema. Verifique o console.");
            }
        });
    }
});