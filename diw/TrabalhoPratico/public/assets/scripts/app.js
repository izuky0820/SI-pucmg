const API_URL = window.location.hostname === 'localhost'
  ? "http://localhost:3000/destaque"
  : "/api/destaque";

let editarModal;

// ==========================
// FOOTER
// ==========================
const dadosFooter = {
  "id": 1,
  "Nome": "Evelyn Maestre",
  "Sobre": "Técnica em informática, graduanda em Sistemas de Informação",
  "Curso": "Sistemas de Informção",
  "Turno": "Noite",
  "Contato": [
    { "Email": "evelynmaestre5@gmail.com" },
    { "Telefone": "(31) 9 8883-9964" }
  ],
  "Redes": [
    { "Instagram": "https://www.instagram.com/__izuky__/" }
  ]
};

function carregarFooter() {
  const container = document.getElementById("footer-content");
  if (!container) return;
  let contatosHtml = '';
  dadosFooter.Contato.forEach(item => {
    const chave = Object.keys(item)[0];
    const valor = item[chave];
    contatosHtml += `<p class="mb-1"><strong class="text-white">${chave}:</strong> ${valor}</p>`;
  });
  let redesHtml = '';
  dadosFooter.Redes.forEach(item => {
    const chave = Object.keys(item)[0];
    const link = item[chave];
    redesHtml += `<a href="${link}" target="_blank" class="text-white me-3 text-decoration-none">
                    <i class="fa-brands fa-${chave.toLowerCase()} fa-lg"></i> ${chave}
                  </a>`;
  });

  container.innerHTML = `
    <div class="row text-white py-4">
      <div class="col-md-6">
        <h5 class="text-white">${dadosFooter.Nome}</h5>
        <p>${dadosFooter.Sobre}</p>
        <p class="small text-secondary">${dadosFooter.Curso} - ${dadosFooter.Turno}</p>
      </div>
      <div class="col-md-3">
        <h6 class="text-uppercase text-white fw-bold">Contato</h6>
        ${contatosHtml}
      </div>
      <div class="col-md-3">
        <h6 class="text-uppercase text-white fw-bold">Siga-me</h6>
        <div class="mt-2">
            ${redesHtml}
        </div>
      </div>
    </div>
    <div class="text-center text-secondary mt-3 border-top border-secondary pt-3">
      <small>&copy; 2024 Desenvolvido por ${dadosFooter.Nome}</small>
    </div>
  `;
}

// --- Usuário logado ---
function getUsuarioAtual() {
  const userRaw = localStorage.getItem("usuarioLogado");
  if (!userRaw || userRaw === "undefined") {
    return null;
  }
  try {
    return JSON.parse(userRaw);
  } catch (error) {

    console.error("Erro ao ler usuário:", error);
    localStorage.removeItem("usuarioLogado");
    return null;
  }
}

function getUserFavoritos() {
  const user = getUsuarioAtual();
  if (!user) return [];
  return JSON.parse(localStorage.getItem(`favoritos_${user.id}`)) || [];
}

function setUserFavoritos(favs) {
  const user = getUsuarioAtual();
  if (!user) return;
  localStorage.setItem(`favoritos_${user.id}`, JSON.stringify(favs));
}

function isFavorito(id) {
  return getUserFavoritos().includes(id);
}

function toggleFavorito(id) {
  let favs = getUserFavoritos();
  const icon = document.querySelector(`.fav-icon[data-id="${id}"]`);
  const user = getUsuarioAtual();
  if (!user) {
    alert("Você precisa estar logado para favoritar álbuns.");
    window.location.href = "login.html";
    return;
  }
  // Animação do clique
  if (icon) {
    icon.classList.add("clicked");
    setTimeout(() => icon.classList.remove("clicked"), 200);
  }

  if (favs.includes(id)) favs = favs.filter(f => f !== id);
  else favs.push(id);

  setUserFavoritos(favs);
  atualizarCoracoes();
  if (document.getElementById("listaFavoritos")) carregarFavoritos();
}

function atualizarCoracoes() {
  const favoritos = getUserFavoritos();

  document.querySelectorAll(".fav-icon").forEach(icon => {
    const id = String(icon.dataset.id);
    icon.innerHTML = favoritos.includes(id)
      ? `<i class="fa-solid fa-heart text-danger"></i>`
      : `<i class="fa-regular fa-heart"></i>`;
  });
}

// --- Favoritos  ---
async function carregarFavoritos() {
  const container = document.getElementById("listaFavoritos");
  if (!container) return;

  const favs = getUserFavoritos();
  container.innerHTML = "";

  if (!favs.length) {
    container.innerHTML = `
      <div class="text-center mt-4">
        <h4>😢 Nenhum favorito por enquanto</h4>
        <p>Marque um álbum com ❤️ para aparecer aqui.</p>
      </div>`;
    return;
  }

  const resp = await fetch(API_URL);
  const albuns = await resp.json();
  const filtrados = albuns.filter(a => favs.includes(a.id));

  if (!filtrados.length) {
    container.innerHTML = `
      <div class="text-center mt-4">
        <h4>😢 Nenhum favorito encontrado</h4>
        <p>Talvez tenham sido removidos do servidor.</p>
      </div>`;
    return;
  }

  filtrados.forEach(album => {
    const col = document.createElement("div");
    col.className = "col-md-4";
    col.innerHTML = `
      <div class="card bg-dark text-white h-100 card-album" data-id="${album.id}">
        <img src="${album.imagem}" class="card-img-top">
        <div class="card-body">
          <h5 class="card-title">${album.album}</h5>
          <p class="card-text">Lançamento: ${album.lancamento}</p>
          <button class="btn btn-outline-danger w-100 mt-2 btn-remove-fav" data-id="${album.id}">
            <i class="fa-solid fa-heart-crack"></i> Remover
          </button>
        </div>
      </div>`;
    container.appendChild(col);
  });
  document.querySelectorAll(".btn-remove-fav").forEach(btn => {
    btn.addEventListener("click", e => {
      e.stopPropagation();
      removerFavorito(String(btn.dataset.id));
    });
  });

  document.querySelectorAll("#listaFavoritos .card-album").forEach(card => {
    card.addEventListener("click", e => {
      if (!e.target.closest(".btn-remove-fav")) {
        abrirAlbum(card.dataset.id);
      }
    });
  });
}
function removerFavorito(id) {
  let favs = getUserFavoritos();
  favs = favs.filter(f => String(f) !== String(id));
  
  setUserFavoritos(favs);
  atualizarCoracoes();
  carregarFavoritos();
}

// --- Busca ---
function configurarBusca() {
  const btnBusca = document.getElementById('btnBusca');
  const campoBusca = document.getElementById('campoBusca');
  if (!btnBusca || !campoBusca) return;
  btnBusca.addEventListener('click', () => {
    campoBusca.style.display = campoBusca.style.display === 'none' ? 'inline-block' : 'none';
    if (campoBusca.style.display === 'inline-block') campoBusca.focus();
  });
}

function pesquisar() {
  const campoBusca = document.getElementById('campoBusca');
  const termo = campoBusca.value.toLowerCase();
  const cards = document.querySelectorAll('.card-album');
  let encontrados = 0;

  cards.forEach(card => {
    const titulo = card.querySelector('.card-title').textContent.toLowerCase();
    const ano = card.querySelector('.card-text').textContent.toLowerCase();
    const match = titulo.includes(termo) || ano.includes(termo);
    card.parentElement.style.display = match ? 'block' : 'none';
    if (match) encontrados++;
  });
}

// --- Carregar destaques ---
async function carregarDestaques() {
  const container = document.getElementById("destaques");
  if (!container) return;

  const resp = await fetch(API_URL);
  const destaque = await resp.json();

  container.innerHTML = "";
  const usuario = getUsuarioAtual();
  const isAdmin = usuario && usuario.tipo === "admin";

  destaque.forEach(album => {
    const col = document.createElement("div");
    col.className = "col-md-4 mb-4";
    let menuAdminHtml = "";
    if (isAdmin) {
      menuAdminHtml = `
        <div class="acoes position-absolute top-0 end-0 m-2" style="z-index: 10;">
          <button class="btn btn-dark btn-sm menu-btn" data-id="${album.id}">⋮</button>
          <div class="menu-opcoes bg-dark border rounded p-2 d-none" id="menu-${album.id}" style="position: absolute; right: 0; min-width: 100px;">
            <button class="btn btn-warning btn-sm w-100 mb-1 edit-btn" data-id="${album.id}">Editar</button>
            <button class="btn btn-danger btn-sm w-100 delete-btn" data-id="${album.id}">Excluir</button>
          </div>
        </div>`;
    }

    col.innerHTML = `
      <div class="card bg-dark text-white h-100 card-album" style="cursor:pointer; position:relative;">
        
        ${menuAdminHtml} <img src="${album.imagem}" class="card-img-top" alt="${album.album}">
        <div class="card-body">
          <h5 class="card-title">${album.album}</h5>
          <p class="card-text">Lançamento: ${album.lancamento}</p>
          
          <div class="fav-icon" data-id="${album.id}" style="font-size: 1.5rem; cursor: pointer;">
            <i class="fa-regular fa-heart"></i>
          </div>
        </div>
      </div>`;

    container.appendChild(col);

    if (isAdmin) {
      const menuBtn = col.querySelector(".menu-btn");
      const menuOpcoes = col.querySelector(`#menu-${album.id}`);

      menuBtn.addEventListener("click", (e) => {
        e.stopPropagation();
        document.querySelectorAll('.menu-opcoes').forEach(m => {
          if (m.id !== `menu-${album.id}`) m.classList.add('d-none');
        });
        menuOpcoes.classList.toggle("d-none");
      });

      col.querySelector(".edit-btn").addEventListener("click", (e) => {
        e.stopPropagation();
        menuOpcoes.classList.add("d-none");
        editarAlbum(album.id);
      });

      col.querySelector(".delete-btn").addEventListener("click", (e) => {
        e.stopPropagation();
        menuOpcoes.classList.add("d-none");
        excluirAlbum(album.id);
      });
    }

    // Botão Favorito (Lógica de proteção já estava boa, mantendo aqui)
    const favIcon = col.querySelector(".fav-icon");
    favIcon.addEventListener("click", (e) => {
      e.stopPropagation();
      toggleFavorito(album.id); // Essa função já verifica se está logado e redireciona
    });

    // Clique no Card (abrir detalhes)
    const cardElement = col.querySelector(".card-album");
    cardElement.addEventListener("click", (e) => {
      // Evita abrir detalhes se clicou no menu ou no coração
      if (!e.target.closest('.acoes') && !e.target.closest('.fav-icon')) {
        abrirAlbum(album.id);
      }
    });
  });

  atualizarCoracoes();
}



// --- Abrir detalhes ---
function abrirAlbum(id) {
  window.location.href = `detalhes.html?id=${id}`;
}

// --- Edição ---
async function editarAlbum(id) {
  try {
    const resp = await fetch(`${API_URL}/${id}`);
    const album = await resp.json();

    document.getElementById("editId").value = album.id;
    document.getElementById("editNome").value = album.album;
    document.getElementById("editAno").value = album.lancamento;
    document.getElementById("editImagem").value = album.imagem;
    document.getElementById("editInfo").value = album.informacoes || "";

    if (editarModal) {
      editarModal.show();
    } else {
      alert("Erro: Modal de edição não foi carregado corretamente.");
    }
  } catch (error) {
    console.error("Erro ao buscar dados para edição:", error);
  }
}

async function salvarEdicao() {
  const id = document.getElementById("editId").value;
  const albumAtualizado = {
    album: document.getElementById("editNome").value,
    lancamento: document.getElementById("editAno").value,
    imagem: document.getElementById("editImagem").value,
    informacoes: document.getElementById("editInfo").value
  };

  try {
    await fetch(`${API_URL}/${id}`, {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(albumAtualizado)
    });

    if (editarModal) editarModal.hide();
    carregarDestaques();
  } catch (error) {
    console.error("Erro ao salvar edição:", error);
    alert("Erro ao salvar alterações.");
  }
}

async function excluirAlbum(id) {
  if (!confirm("Tem certeza que deseja excluir este álbum?")) return;
  try {
    await fetch(`${API_URL}/${id}`, { method: "DELETE" });
    carregarDestaques();
  } catch (error) {
    console.error("Erro ao excluir:", error);
    alert("Não foi possível excluir o álbum.");
  }
}

function configurarBotaoLogin() {
  const btnAuth = document.getElementById("btnAuth");

  if (!btnAuth) return;

  const usuario = getUsuarioAtual();

  if (usuario) {
    btnAuth.textContent = "Sair";
    btnAuth.href = "#";


    btnAuth.onclick = (e) => {
      e.preventDefault();
      if (confirm("Deseja realmente sair?")) {
        localStorage.removeItem("usuarioLogado");
        window.location.reload();
      }
    };
    const msgOla = document.getElementById("msgOla");
    if (msgOla) msgOla.textContent = `Olá, ${usuario.nome}!`;

  } else {

    btnAuth.textContent = "Login";
    btnAuth.href = "login.html";
    btnAuth.onclick = null;
  }
}

// --- Inicialização ---
document.addEventListener("DOMContentLoaded", () => {
  configurarBusca();
  carregarDestaques();
  if (document.getElementById("listaFavoritos")) carregarFavoritos();
  carregarFooter();
  configurarBotaoLogin();
  const modalElement = document.getElementById('editarModal');
  if (modalElement) {
    if (typeof bootstrap !== 'undefined') {
      editarModal = new bootstrap.Modal(modalElement);
    } else {
      console.error("Bootstrap JS não foi carregado!");
    }
  }
  const usuario = getUsuarioAtual();
  const btnAddAlbum = document.getElementById("btnAdicionarAlbum");
  if (btnAddAlbum && usuario && usuario.tipo === "admin") {
    btnAddAlbum.classList.remove("d-none");
  }
});
