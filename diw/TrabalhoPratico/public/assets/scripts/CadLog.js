// =============================================================
// CONFIG GLOBAL
// =============================================================
const API_URL = "http://localhost:3000/usuarios";

/* =============================================================
   CADASTRO 
============================================================= */
document.addEventListener('DOMContentLoaded', () => {
    const formCadastro = document.getElementById("formCadastro");

    if (formCadastro) {
        formCadastro.addEventListener('submit', async (event) => {
            event.preventDefault();

            const nome = document.getElementById('nome').value;
            const email = document.getElementById('email').value.trim().toLowerCase();
            const senha = document.getElementById('senha').value;

            const novoUsuario = { nome, email, senha };

            try {
                const checkResponse = await fetch(`${API_URL}?email=${encodeURIComponent(email)}`);
                const checkData = await checkResponse.json();

                if (checkData.length > 0) {
                    alert("Este e-mail já está cadastrado! Tente fazer login.");
                    return;
                }

                const response = await fetch(API_URL, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(novoUsuario)
                });

                if (!response.ok) {
                    throw new Error('Falha na comunicação com o servidor');
                }

                alert("Cadastro realizado com sucesso!");
                window.location.href = 'login.html';

            } catch (error) {
                console.error("Erro no cadastro:", error);
                alert("Erro ao cadastrar. Verifique se o json-server está rodando.");
            }
        });
    }
});

/* =============================================================
   LOGIN 
============================================================= */
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

            try {
                const urlBusca = `${API_URL}?email=${emailEncoded}&senha=${senhaEncoded}`;
                const response = await fetch(urlBusca);
                const usuarios = await response.json();

                if (usuarios.length === 0) {
                    const checkEmailResp = await fetch(`${API_URL}?email=${emailEncoded}`);
                    const checkEmailData = await checkEmailResp.json();
                    
                    if(checkEmailData.length > 0) {
                        alert("Senha incorreta!");
                    } else {
                        alert("E-mail não encontrado. Cadastre-se primeiro.");
                    }
                    return;
                }
                const usuario = usuarios[0];

                localStorage.setItem("usuarioLogado", JSON.stringify(usuario)); 

                alert("Login realizado com sucesso!");
        
                window.location.href = 'index.html'; 

            } catch (error) {
                console.error("Erro no login:", error);
                alert("Erro ao conectar. O json-server está ligado?");
            }
        });
    }
});