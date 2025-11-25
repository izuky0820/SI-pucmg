// =============================================================
// CONFIG GLOBAL
// =============================================================
const API_USERS = "http://localhost:3000/usuarios";

/* =============================================================
   CADASTRO 
============================================================= */
document.addEventListener('DOMContentLoaded', () => {
    const formCadastro = document.getElementById("formCadastro");

    if (formCadastro) {
        formCadastro.addEventListener('submit', async (event) => {
            event.preventDefault();

            const nome = document.getElementById('nome').value.trim();
            const email = document.getElementById('email').value.trim().toLowerCase();
            const senha = document.getElementById('senha').value.trim();
            const novoUsuario = {
                nome,
                email,
                senha,
                tipo: "comum"
            };

            try {
                const checkResponse = await fetch(`${API_USERS}?email=${encodeURIComponent(email)}`);
                const checkData = await checkResponse.json();

                if (checkData.length > 0) {
                    alert("Este e-mail já está cadastrado! Tente fazer login.");
                    return;
                }

                await fetch(API_USERS, {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(novoUsuario)
                });

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

            const email = document.getElementById("email").value.trim().toLowerCase();
            const senha = document.getElementById("senha").value.trim();

            try {
                const response = await fetch(`${API_USERS}?email=${email}&senha=${senha}`);
                const usuarios = await response.json();

                if (usuarios.length === 0) {
                    alert("Email ou senha incorretos!");
                    return;
                }

                const usuario = usuarios[0]; // AGORA EXISTE

                // SALVA CORRETAMENTE
                localStorage.setItem("usuarioLogado", JSON.stringify(usuario));

                alert("Login realizado com sucesso!");
                window.location.href = "index.html";

            } catch (error) {
                console.error("Erro no login:", error);
                alert("Erro ao conectar. O json-server está ligado?");
            }
        });
    }
});
